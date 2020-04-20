using System;
using System.Drawing;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Visual.Styles;

namespace Drakon.Core.Default.Visual.Styles
{
    /// <summary>
    /// Bae shape implementation
    /// </summary>
    public abstract class BaseShapeStyle : Observable, IShapeStyle
    {
        private bool _isFilled;
        private int _borderThickness;
        private Color _fillColor;
        private Color _borderColor;
        private string _fontFamily;
        private int _fontSize;
        private int _rotation;

        public int Rotation
        {
            get => _rotation; 
            set => SetProperty(ref _rotation, value);
        }

        public bool IsFilled
        {
            get => _isFilled;
            set
            {
                if (_isFilled == value) return;
                _isFilled = value;
                Notify(IsFilled, nameof(IsFilled));
            }
        }

        public bool IsSelected { get; set; }

        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                if (_borderThickness == value) return;
                _borderThickness = value;
                Notify(BorderThickness, nameof(BorderThickness));
            }
        }

        public Color FillColor
        {
            get => _fillColor;
            set
            {
                if (_fillColor == value) return;
                _fillColor = value;
                Notify(FillColor, nameof(FillColor));
            }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (_borderColor == value) return;
                _borderColor = value;
                Notify(BorderColor, nameof(BorderColor));
            }
        }

        public string FontFamily
        {
            get => _fontFamily;
            set
            {
                if(_fillColor.Equals(value)) return;
                _fontFamily = value;
                Notify(FontFamily, nameof(FontFamily));
            }
        }

        public int FontSize
        {
            get => _fontSize;
            set
            {
                if (_fontSize == value) return;
                _fontSize = value;
                Notify(FontSize, nameof(FontSize));
            }
        }

        protected bool Equals(BaseShapeStyle other)
        {
            return _isFilled == other._isFilled && 
                   _borderThickness == other._borderThickness && 
                   _fillColor.Equals(other._fillColor) && 
                   _borderColor.Equals(other._borderColor) && 
                   _fontFamily == other._fontFamily && 
                   _fontSize == other._fontSize;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BaseShapeStyle) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_isFilled, _borderThickness, 
                _fillColor, _borderColor, _fontFamily, _fontSize);
        }
    }
}
