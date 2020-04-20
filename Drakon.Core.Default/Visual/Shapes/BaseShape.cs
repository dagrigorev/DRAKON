using System;
using System.Drawing;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Visual.Shapes;
using Drakon.Core.Visual.Styles;

namespace Drakon.Core.Default.Visual.Shapes
{
    /// <summary>
    /// Base shape implementation that notifies observable properties
    /// </summary>
    public abstract class BaseShape : Observable, IShape
    {
        private Point _point;
        private IShapeStyle _shapeStyle;
        private string _label;
        private bool _isSelected;

        public Point Position
        {
            get => _point;
            set
            {
                if (_point == value) return;
                _point = value;
                Notify(Position, nameof(Position));
            }
        }

        public IShapeStyle Style
        {
            get => _shapeStyle;
            set
            {
                if (_shapeStyle == value) return;
                _shapeStyle = value;
                Notify(Style, nameof(Style));
            }
        }

        public string Label
        {
            get => _label;
            set
            {
                if (_label == value) return;
                _label = value;
                Notify(Label, nameof(Label));
            }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected == value) return;
                _isSelected = value;
                if(_isSelected)
                    Select();
                else
                    Unselect();

                Notify(IsSelected, nameof(IsSelected));
            }
        }

        public IShape ConnectedShape { get; set; }

        public BaseShape()
        {
            Position = Point.Empty;
            IsSelected = true;
        }

        public void Select()
        {
            throw new NotImplementedException();
        }

        public void Unselect()
        {
            throw new NotImplementedException();
        }
    }
}
