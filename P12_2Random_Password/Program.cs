
string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

Random random = new Random();

string password = string.Empty;

for (int i = 0; i < 6; i++) {
    password += chars[random.Next(chars.Length)];
}

Console.WriteLine($"Your new password is: {password}");

string gotoPassword = string.Empty;

backtrack:

gotoPassword += chars[random.Next(chars.Length)];

if (gotoPassword.Length < 6) {
    goto backtrack;
}

Console.WriteLine($"Your new password is: {gotoPassword}");