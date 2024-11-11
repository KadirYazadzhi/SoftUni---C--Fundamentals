using System;
using System.Text;

public class BigNumber {
    private string number;
    
    public BigNumber(string number) {
        if (!IsValidNumber(number)) {
            throw new ArgumentException("Invalid number format");
        }
        
        this.number = number.TrimStart('0');
        if (this.number == "")
            this.number = "0";
    }
    
    private bool IsValidNumber(string number) {
        foreach (char c in number) {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }
    
    public static BigNumber Add(BigNumber a, BigNumber b) {
        string result = AddStrings(a.number, b.number);
        return new BigNumber(result);
    }

    private static string AddStrings(string num1, string num2) {
        StringBuilder result = new StringBuilder();
        int carry = 0;

        int len1 = num1.Length;
        int len2 = num2.Length;
        
        int maxLength = Math.Max(len1, len2);
        
        for (int i = 0; i < maxLength; i++) {
            int digit1 = (i < len1) ? num1[len1 - 1 - i] - '0' : 0;
            int digit2 = (i < len2) ? num2[len2 - 1 - i] - '0' : 0;
            
            int sum = digit1 + digit2 + carry;
            carry = sum / 10;
            result.Insert(0, sum % 10);
        }

        if (carry > 0) {
            result.Insert(0, carry);
        }

        return result.ToString();
    }


    public static BigNumber Multiply(BigNumber a, BigNumber b) {
        string result = MultiplyStrings(a.number, b.number);
        return new BigNumber(result);
    }

    private static string MultiplyStrings(string num1, string num2) {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int[] result = new int[len1 + len2];
        
        for (int i = len1 - 1; i >= 0; i--) {
            for (int j = len2 - 1; j >= 0; j--) {
                int product = (num1[i] - '0') * (num2[j] - '0');
                int p1 = i + j;
                int p2 = i + j + 1;
                
                int sum = product + result[p2];
                
                result[p2] = sum % 10;
                result[p1] += sum / 10;
            }
        }
        
        StringBuilder sb = new StringBuilder();
        foreach (int num in result) {
            if (!(sb.Length == 0 && num == 0)) {
                sb.Append(num);
            }
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
    
    public override string ToString() {
        return this.number;
    }
}

public class Program {
    public static void Main() {
        BigNumber num1 = new BigNumber(Console.ReadLine());
        BigNumber num2 = new BigNumber(Console.ReadLine());
        BigNumber result = BigNumber.Multiply(num1, num2);
        
        Console.WriteLine(result);
    }
}
