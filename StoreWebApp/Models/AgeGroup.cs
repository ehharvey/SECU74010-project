using Microsoft.EntityFrameworkCore;

namespace StoreWebApp.Models;

public class AgeGroup
{
    public int Id { get; set; }
    public required string AgeGroupName { get; set; }
}