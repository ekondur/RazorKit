namespace RazorKit.DataTables.Data
{
    public class FilterDef
    {
        public string Field { get; set; }
        public string Value { get; set; }
        public DataOperand Operand { get; set; }
        public DataOperator Operator { get; set; }
    }

    public enum DataOperand
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        Contains,
        StartsWith,
        EndsWith
    }

    public enum DataOperator
    {
        And,
        Or
    }
}
