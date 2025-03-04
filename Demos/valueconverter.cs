public class User
{
	public int UserId { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
}

public static class EncryptionHelper
{
	private static readonly string EncryptionKey = "your-encryption-key"; // Use a secure key management approach in production.

	public static string Encrypt(string input)
	{
		// Simple encryption logic (just for demonstration purposes)
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		return Convert.ToBase64String(bytes);
	}

	public static string Decrypt(string input)
	{
		// Simple decryption logic (just for demonstration purposes)
		byte[] bytes = Convert.FromBase64String(input);
		return Encoding.UTF8.GetString(bytes);
	}
}

public class ApplicationDbContext : DbContext
{
	public DbSet<User> Users { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Create a value converter for encrypting and decrypting Email
		var emailEncryptor = new ValueConverter<string, string>(
			v => EncryptionHelper.Encrypt(v),  // Encrypt Email before saving to DB
			v => EncryptionHelper.Decrypt(v));  // Decrypt Email when reading from DB

		modelBuilder.Entity<User>()
			.Property(u => u.Email)
			.HasConversion(emailEncryptor);
	}
}
