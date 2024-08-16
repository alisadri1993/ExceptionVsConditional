
# Why Not to Use Exception Handling Instead of Validation

## Introduction
This repository demonstrates the performance and readability differences between using exception handling and validation checks in C#. It provides examples and benchmarks to illustrate why validation checks are generally preferred over exceptions for handling regular control flow.

## Contents
•  `ExceptionVsConditionalBenchmark.cs`: Contains the benchmark code comparing exception handling and validation checks.

•  `README.md`: This file, explaining the purpose and contents of the repository.


## Getting Started

### Prerequisites
•  .NET SDK

•  BenchmarkDotNet library


### Installing BenchmarkDotNet
To install BenchmarkDotNet, run the following command in the Package Manager Console:
```bash
Install-Package BenchmarkDotNet

Running the Benchmark

Clone the repository:

https://github.com/alisadri1993/ExceptionVsConditional.git

Navigate to the project directory:

cd ExceptionVsValidation

Build and run the project:

dotnet run -c Release

BenchmarkDotNet will execute the benchmark methods and provide detailed performance statistics.

Example Code
Using Conditional Checks
public int DivideWithConditional(int numerator, int denominator)
{
  if (denominator == 0)
  {
    return -1; // Indicate an error
  }
  return numerator / denominator;
}

Using Exceptions
public int DivideWithException(int numerator, int denominator)
{
  try
  {
    return numerator / denominator;
  }
  catch (DivideByZeroException)
  {
    return -1; // Indicate an error
  }
}

Benchmark Results
The benchmark results show that using conditional checks is significantly faster than using exceptions for handling validation errors. Exceptions involve additional overhead due to object creation, stack unwinding, and context switching.

Sample Output
| Method                | Mean           | Error       | StdDev        | Median         |
|---------------------- |---------------:|------------:|--------------:|---------------:|
| DivideWithConditional |      0.1601 ns |   0.0584 ns |     0.1558 ns |      0.1255 ns |
| DivideWithException   | 16,013.7829 ns | 753.4037 ns | 2,209.6029 ns | 15,950.1633 ns |

Conclusion
•  Performance: Conditional checks are much faster than exceptions for handling validation errors.

•  Readability: Code using conditional checks is generally easier to read and understand.

•  Best Practices: Use exceptions for truly exceptional conditions, not for regular control flow.


Acknowledgments
•  BenchmarkDotNet for providing a powerful benchmarking library.

•  Microsoft Documentation for guidelines on exceptions and performance.
