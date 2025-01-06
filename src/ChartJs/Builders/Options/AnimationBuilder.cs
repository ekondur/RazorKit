using RazorKit.ChartJs.Models;
using System.Collections.Generic;

namespace RazorKit.ChartJs.Builders
{
    /// <summary>
    /// Animation Builder
    /// </summary>
    public class AnimationBuilder
    {
        private Animation _animation;
        private readonly Dictionary<string, Animation> _animations;

        internal AnimationBuilder(Animation animation)
        {
            _animation = animation;
        }

        internal AnimationBuilder(Dictionary<string, Animation> animations)
        {
            _animations = animations;
        }

        /// <summary>
        /// Namespace: options.animations[animation] for example: "x", "y", "borderWidth", "radius", "tension"
        /// </summary>
        /// <param name="animation"></param>
        /// <returns></returns>
        public AnimationBuilder Animation(string animation)
        {
            _animation = new Animation();
            _animations.Add(animation, _animation);
            return this;
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
        public AnimationBuilder Easing(AnimationEasing easing)
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
