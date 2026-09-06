namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<PizzaData[]> GetPizzasAsync()
    {
        // TODO: Call your data access technology here
        return Task.FromResult(Array.Empty<PizzaData>());
    }
}
