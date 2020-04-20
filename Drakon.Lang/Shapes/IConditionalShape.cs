using Drakon.Core.Common.Collections;
using Drakon.Core.Visual.Shapes;

namespace Drakon.Lang.Shapes
{
    /// <summary>
    /// Conditional tool shape contract
    /// </summary>
    public interface IConditionalShape : IRectangleShape
    {
        /// <summary>
        /// Connection points for input args
        /// </summary>
        IObservableStack<IPointShape> InputArgumentPoints { get; set; }

        /// <summary>
        /// Expression `True` output point shape
        /// </summary>
        IPointShape OutputTruePoint { get; set; }

        /// <summary>
        /// Expression `False` output point shape
        /// </summary>
        IPointShape OutputFalsePoint { get; set; }
    }
}