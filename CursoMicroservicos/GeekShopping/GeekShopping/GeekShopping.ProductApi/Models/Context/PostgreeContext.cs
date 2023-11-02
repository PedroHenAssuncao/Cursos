using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Models.Context
{
    public class PostgreeContext : DbContext
    {
        public PostgreeContext() { }

        public PostgreeContext(DbContextOptions<PostgreeContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("6e32a998-44b1-4e7c-bfb4-654171a29f11"),
                Name = "Blusa Dragon Ball",
                Price = new decimal(69.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed turpis lorem, elementum ac efficitur et," +
                              " ullamcorper nec velit. Sed aliquam tortor quis dui efficitur suscipit." +
                              " Etiam quis ipsum vitae risus tempor faucibus. Nam at sem semper, porta elit non, placerat erat." +
                              " Maecenas finibus quam porttitor lacus luctus, sit amet fringilla quam laoreet." +
                              " Curabitur convallis malesuada dolor, sed gravida nibh mattis ac. Etiam ut orci id leo iaculis viverra.",
                ImagemUrl = "https://github.com/PedroHenAssuncao/Cursos/blob/c04646bcffcc838c098af96b9b7b84ef2f963884/CursoMicroservicos/ShoppingImages/13_dragon_ball.jpg",
                CategoryName = "T-shirts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("a64fff47-f14a-4c8a-b28e-fed9043ce0ff"),
                Name = "Millenium Falcom",
                Price = new decimal(80.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed turpis lorem, elementum ac efficitur et," +
                              " ullamcorper nec velit. Sed aliquam tortor quis dui efficitur suscipit." +
                              " Etiam quis ipsum vitae risus tempor faucibus. Nam at sem semper, porta elit non, placerat erat." +
                              " Maecenas finibus quam porttitor lacus luctus, sit amet fringilla quam laoreet." +
                              " Curabitur convallis malesuada dolor, sed gravida nibh mattis ac. Etiam ut orci id leo iaculis viverra.",
                ImagemUrl = "https://github.com/PedroHenAssuncao/Cursos/blob/c04646bcffcc838c098af96b9b7b84ef2f963884/CursoMicroservicos/ShoppingImages/10_milennium_falcon.jpg",
                CategoryName = "Toys"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("56fc20ef-d029-42d9-9ee6-e0afc655d437"),
                Name = "Blusa Marte",
                Price = new decimal(69.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed turpis lorem, elementum ac efficitur et," +
                              " ullamcorper nec velit. Sed aliquam tortor quis dui efficitur suscipit." +
                              " Etiam quis ipsum vitae risus tempor faucibus. Nam at sem semper, porta elit non, placerat erat." +
                              " Maecenas finibus quam porttitor lacus luctus, sit amet fringilla quam laoreet." +
                              " Curabitur convallis malesuada dolor, sed gravida nibh mattis ac. Etiam ut orci id leo iaculis viverra.",
                ImagemUrl = "https://github.com/PedroHenAssuncao/Cursos/blob/c04646bcffcc838c098af96b9b7b84ef2f963884/CursoMicroservicos/ShoppingImages/11_mars.jpg",
                CategoryName = "T-shirts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("4b7f20ee-9d75-4520-8f9a-b7b5f8fef7d8"),
                Name = "Blusa Gnu Linux",
                Price = new decimal(69.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed turpis lorem, elementum ac efficitur et," +
                              " ullamcorper nec velit. Sed aliquam tortor quis dui efficitur suscipit." +
                              " Etiam quis ipsum vitae risus tempor faucibus. Nam at sem semper, porta elit non, placerat erat." +
                              " Maecenas finibus quam porttitor lacus luctus, sit amet fringilla quam laoreet." +
                              " Curabitur convallis malesuada dolor, sed gravida nibh mattis ac. Etiam ut orci id leo iaculis viverra.",
                ImagemUrl = "https://github.com/PedroHenAssuncao/Cursos/blob/c04646bcffcc838c098af96b9b7b84ef2f963884/CursoMicroservicos/ShoppingImages/12_gnu_linux.jpg",
                CategoryName = "T-shirts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.Parse("03185ec2-3f2f-4cb3-80f6-0babbd277d31"),
                Name = "Caneca Mario",
                Price = new decimal(69.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed turpis lorem, elementum ac efficitur et," +
                              " ullamcorper nec velit. Sed aliquam tortor quis dui efficitur suscipit." +
                              " Etiam quis ipsum vitae risus tempor faucibus. Nam at sem semper, porta elit non, placerat erat." +
                              " Maecenas finibus quam porttitor lacus luctus, sit amet fringilla quam laoreet." +
                              " Curabitur convallis malesuada dolor, sed gravida nibh mattis ac. Etiam ut orci id leo iaculis viverra.",
                ImagemUrl = "https://github.com/PedroHenAssuncao/Cursos/blob/c04646bcffcc838c098af96b9b7b84ef2f963884/CursoMicroservicos/ShoppingImages/1_super_mario.jpg",
                CategoryName = "Mug"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
