namespace mySmartWallet2022.Models.Data.Entities
{
    public class SeedHelperClass
    {
        public static async Task seed(ApplicationDbContext context)
        {
            if (!context.Customers.Any())
            {

                context.Customers.Add(new Customer

                {
                    FirstName = "Maxwell",
                    LastName = "Bernard",
                    MiddleName = "Boji",
                    gender = GenderEnum.male,
                    MaritalStatus = MaritalStatusEnum.Married,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "USA",
                    State = "New york",
                    City = "Weschester",
                    Active = true,

                });
                context.Customers.Add(new Customer

                {
                    FirstName = "Stephen",
                    LastName = "Uti",
                    MiddleName = "Amos",
                    gender = GenderEnum.male,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-9),
                    Country = "USA",
                    State = "Los angeles",
                    City = "California",
                    Active = true,

                }
                    );
                // context.SaveChangesAsync();
                await context.SaveChangesAsync();
            }
        
        }
    }
}
