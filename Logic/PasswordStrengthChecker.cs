
namespace Hidepass.Logic
{
    public static class PasswordStrengthChecker
    {
        public static int Evaluate(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return 1;

            int score = 0;

            if (password.Length >= 12) score += 3;
            else if (password.Length >= 8) score += 2;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(c => !char.IsLetterOrDigit(c));

            int charTypeCount = new[] { hasUpper, hasLower, hasDigit, hasSpecial }.Count(b => b);

            if (charTypeCount >= 4) score += 2;
            else if (charTypeCount >= 3) score += 1;

            if (HasRepeatingChars(password)) score -= 1;
            if (HasSequentialChars(password)) score -= 1;
            if (IsCommonPassword(password)) score = Math.Max(score - 2, 0);

            return Math.Clamp(score, 1, 5);
        }

        private static bool HasRepeatingChars(string password)
        {
            for (int i = 0; i < password.Length - 2; i++)
                if (password[i] == password[i + 1] && password[i] == password[i + 2])
                    return true;
            return false;
        }

        private static bool HasSequentialChars(string password)
        {
            for (int i = 0; i < password.Length - 2; i++)
            {
                int diff1 = password[i + 1] - password[i];
                int diff2 = password[i + 2] - password[i + 1];
                if (Math.Abs(diff1) == 1 && diff1 == diff2)
                    return true;
            }
            return false;
        }

        private static bool IsCommonPassword(string password)
        {
            string[] commonPasswords = {
            "пароль", "password", "1111", "1234", "1234567890",
            "0987654321", "qwerty", "qwerty1234", "12345qwerty", "1"
        };
            return commonPasswords.Contains(password.ToLower());
        }
    }
}