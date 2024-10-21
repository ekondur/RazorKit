using HelperJS.Chart.Models;
using System.Collections.Generic;

namespace HelperJS.Chart.Builders
{
    /// <summary>
    /// Animation Builder
    /// </summary>
    public class AnimationBuilder
    {
        private readonly Animation _animation;

        internal AnimationBuilder(Animation animation)
        {
            _animation = animation;
        }

        internal AnimationBuilder(Options options, string animation)
        {
            _animation = new Animation();
            if (options.Animations == null)
            {
                options.Animations = new Dictionary<string, Animation>();
            }
            options.Animations.Add(animation, _animation);
        }

        /// <summary>
        /// The number of milliseconds an animation takes. Default 1000
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public AnimationBuilder Duration(int duration)
        {
            _animation.Duration = duration;
            return this;
        }

        /// <summary>
        /// Easing function to use. Default 'easeOutQuart'
        /// </summary>
        /// <param name="easing"></param>
        /// <returns></returns>
        public AnimationBuilder Easing(Easing easing)
        {
            _animation.Easing = easing;
            return this;
        }

        /// <summary>
        /// Delay before starting the animations.
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public AnimationBuilder Delay(int delay)
        {
            _animation.Delay = delay;
            return this;
        }

        /// <summary>
        /// If set to true, the animations loop endlessly.
        /// </summary>
        /// <param name="loop"></param>
        /// <returns></returns>
        public AnimationBuilder Loop(bool loop)
        {
            _animation.Loop = loop;
            return this;
        }

        /// <summary>
        /// Callback called on each step of an animation.
        /// </summary>
        /// <param name="onProgress"></param>
        /// <returns></returns>
        public AnimationBuilder OnProgress(string onProgress)
        {
            _animation.OnProgress = onProgress;
            return this;
        }

        /// <summary>
        /// Callback called when all animations are completed.
        /// </summary>
        /// <param name="onComplete"></param>
        /// <returns></returns>
        public AnimationBuilder OnComplete(string onComplete)
        {
            _animation.OnComplete = onComplete;
            return this;
        }

        /// <summary>
        /// Start value for the animation. Current value is used when undefined.
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public AnimationBuilder From(bool from)
        {
            _animation.From = from;
            return this;
        }

        /// <summary>
        /// Start value for the animation. Current value is used when undefined.
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public AnimationBuilder From(int from)
        {
            _animation.From = from;
            return this;
        }

        /// <summary>
        /// Start value for the animation. Current value is used when undefined.
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public AnimationBuilder From(string from)
        {
            _animation.From = from;
            return this;
        }

        /// <summary>
        /// End value for the animation. Updated value is used when undefined
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public AnimationBuilder To(bool to)
        {
            _animation.To = to;
            return this;
        }

        /// <summary>
        /// End value for the animation. Updated value is used when undefined
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public AnimationBuilder To(int to)
        {
            _animation.To = to;
            return this;
        }

        /// <summary>
        /// End value for the animation. Updated value is used when undefined
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public AnimationBuilder To(string to)
        {
            _animation.To = to;
            return this;
        }
    }
}
