namespace DeerCoffeeShop.Api.Controllers.ResponseTypes
{
    /// <summary>
    /// Implicit wrapping of types that serialize to non-complex values.
    /// </summary>
    /// <typeparam name="T">Types such as string, Guid, int, long, etc.</typeparam>
    public class JsonResponse<T>(T value)
    {
        public T Value { get; set; } = value;
    }
}
