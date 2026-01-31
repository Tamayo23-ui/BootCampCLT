/// <summary>
/// Representa un producto dentro del sistema.
/// </summary>
/// <param name="Id">Identificador único del producto.</param>
/// <param name="Name">Nombre del producto.</param>
/// <param name="Price">Precio del producto.</param>
public record ProductDTO(int Id, string Name, decimal Price);
