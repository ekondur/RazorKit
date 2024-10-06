using HelperJS.Chart.Models;

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
    }
}
