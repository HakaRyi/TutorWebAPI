namespace demoAPITutor.Helper
{
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Tự động tạo salt và hash mật khẩu
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Xác minh mật khẩu
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
