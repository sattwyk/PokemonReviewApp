namespace PokemonReviewApp.Dto
{
    //DTO is a way to better control how we display our data
    //otherwise all data will be returned aka security vulnerabilities
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
