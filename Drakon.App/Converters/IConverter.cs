using System;

namespace Drakon.App.Converters
{
    /// <summary>
    /// Base converter contract
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// Converts value
        /// </summary>
        /// <param name="sourceValue"></param>
        /// <returns></returns>
        object Convert(object sourceValue);
    }

    /// <summary>
    /// Value converter contract
    /// </summary>
    public interface IConverter<TSrc, TDst> : IConverter
    {
        TDst Convert(TSrc sourceValue);
    }
}