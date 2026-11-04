using System;
using System.Collections.Generic;

namespace RazorKit.TomSelect.Builders
{
    /// <summary>Builds a fetch-based data source; responses may be arrays or nested result envelopes.</summary>
    public sealed class DataSourceBuilder
    {
        private string _url;
        private string _method = "GET";
        private string _query = "q";
        private string _results;
        private string _groups;
        private string _credentials = "same-origin";
        private int _minimum = 1;
        private readonly Dictionary<string, string> _headers = new Dictionary<string, string>();
        private readonly Dictionary<string, object> _parameters = new Dictionary<string, object>();
        private JavaScript _transform;
        private JavaScript _error;

        /// <summary>Sets the endpoint URL.</summary>
        public DataSourceBuilder Url(string value) { _url = value; return this; }
        /// <summary>Sets GET or POST. POST sends JSON.</summary>
        public DataSourceBuilder Method(string value)
        {
            value = value?.ToUpperInvariant();
            if (value != "GET" && value != "POST") throw new ArgumentException("Use GET or POST.", nameof(value));
            _method = value; return this;
        }
        /// <summary>Sets the query parameter/property name.</summary>
        public DataSourceBuilder QueryParameter(string value) { _query = value; return this; }
        /// <summary>Sets a dot-separated response path to the options array.</summary>
        public DataSourceBuilder ResultsField(string value) { _results = value; return this; }
        /// <summary>Sets a dot-separated response path to an optional groups array.</summary>
        public DataSourceBuilder OptgroupsField(string value) { _groups = value; return this; }
        /// <summary>Sets the minimum input length before loading.</summary>
        public DataSourceBuilder MinimumQueryLength(int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            _minimum = value; return this;
        }
        /// <summary>Sets a request header, for example an antiforgery token header.</summary>
        public DataSourceBuilder Header(string name, string value) { _headers[name] = value; return this; }
        /// <summary>Adds a JSON value or a trusted JavaScript expression evaluated for each request.</summary>
        public DataSourceBuilder Parameter(string name, object value) { _parameters[name] = value; return this; }
        /// <summary>Sets fetch credentials: omit, same-origin or include.</summary>
        public DataSourceBuilder Credentials(string value)
        {
            if (value != "omit" && value != "same-origin" && value != "include") throw new ArgumentException("Invalid fetch credentials.", nameof(value));
            _credentials = value; return this;
        }
        /// <summary>Transforms the server response before extracting options and groups.</summary>
        public DataSourceBuilder Transform(string expression) { _transform = new JavaScript(expression); return this; }
        /// <summary>Handles fetch/response errors after releasing the loading state.</summary>
        public DataSourceBuilder OnError(string expression) { _error = new JavaScript(expression); return this; }

        internal void Apply(TomSelectBuilder owner)
        {
            if (string.IsNullOrWhiteSpace(_url)) throw new InvalidOperationException("A data source URL is required.");
            if (string.IsNullOrWhiteSpace(_query)) throw new InvalidOperationException("A query parameter name is required.");
            var config = ScriptJson.Serialize(new { url = _url, method = _method, query = _query, results = _results, groups = _groups, credentials = _credentials, headers = _headers, parameters = _parameters });
            var transform = _transform == null ? "null" : _transform.Expression;
            var error = _error == null ? "null" : _error.Expression;
            owner.ShouldLoad("function(query){return query.length >= " + _minimum + ";}");
            owner.Load(@"function(query, callback) {
                var self = this, config, transform = " + transform + @", onError = " + error + @";
                Promise.resolve().then(function() {
                    config = " + config + @";
                    var url = new URL(config.url, document.baseURI);
                    var data = Object.assign({}, config.parameters);
                    data[config.query] = query;
                    var request = { method: config.method, credentials: config.credentials, headers: config.headers };
                    if (config.method === 'GET') {
                        Object.keys(data).forEach(function(key) { url.searchParams.set(key, data[key]); });
                    } else {
                        request.headers = Object.assign({'Content-Type': 'application/json'}, config.headers);
                        request.body = JSON.stringify(data);
                    }
                    return fetch(url.toString(), request);
                }).then(function(response) {
                    if (!response.ok) throw new Error('Tom Select request failed: ' + response.status);
                    return response.json();
                }).then(function(data) {
                    return transform ? transform.call(self, data, query) : data;
                }).then(function(data) {
                    function read(path) { return path ? path.split('.').reduce(function(value, key) { return value == null ? undefined : value[key]; }, data) : data; }
                    var options = read(config.results), groups = config.groups ? read(config.groups) : undefined;
                    if (!Array.isArray(options) || (groups !== undefined && !Array.isArray(groups))) throw new Error('Tom Select response must contain arrays.');
                    return {options: options, groups: groups};
                }).then(function(result) {
                    callback(result.options, result.groups);
                }, function(error) {
                    delete self.loadedSearches[query];
                    callback();
                    if (onError) onError.call(self, error, query);
                });
            }");
        }
    }
}
