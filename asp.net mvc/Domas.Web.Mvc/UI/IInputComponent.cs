namespace Domas.Web.Mvc.UI
{
    using System;

    public interface IInputComponent<T> : IWidget where T : struct
    {
        Nullable<T> Value { get; set; }
    }
}
