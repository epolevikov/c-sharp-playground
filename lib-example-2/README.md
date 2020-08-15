# Usage
mcs /t:library fib.cs
mcs /t:library hello.cs
mcs /r:fib /r:hello main.cs
./main.exe
