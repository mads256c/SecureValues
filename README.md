# SecureValues
A way to securely store values in memory. This was made as an anti-cheat-engine measure.

Just add Secure.cs to your project.
The variables are used the same way as a standard variable of its type.

```
using mads256c.secure;

public class Demo
{
  public SecureBool bAllowBugs = false;
  public SecureChar CursorChar = '_';
  public SecureFloat Timer = 0.0f;
  
  public static void Main()
  {
   if (!bAllowBugs)
   timer++;
  }
}
```
