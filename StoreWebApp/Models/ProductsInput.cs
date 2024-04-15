using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models;


public class ProductsInput
{
	public string? FilterString { get; set; } = "";
}