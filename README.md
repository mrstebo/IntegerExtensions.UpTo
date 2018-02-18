# IntegerExtensions.UpTo
A nicer read than Enumerable.Range.

[![Build status](https://ci.appveyor.com/api/projects/status/3bnawqh48ifty8be/branch/master?svg=true)](https://ci.appveyor.com/project/mrstebo/integerextensions-upto/branch/master)
[![Coverage Status](https://coveralls.io/repos/github/mrstebo/IntegerExtensions.UpTo/badge.svg?branch=master)](https://coveralls.io/github/mrstebo/IntegerExtensions.UpTo?branch=master)
[![NuGet](http://img.shields.io/nuget/v/IntegerExtensions.UpTo.svg?style=flat)](https://www.nuget.org/packages/IntegerExtensions.UpTo/)

This package is available via install the [NuGet](https://www.nuget.org/packages/IntegerExtensions.UpTo):

```powershell
Install-Package IntegerExtensions.UpTo
```

## Basic usage

This is a port of Ruby's `upto` method.

```ruby
1.upto(5).to_a # [1, 2, 3, 4, 5]
2.upto(1).to_a # []
```
*can be done like so,*
```cs
1.UpTo(5).ToArray(); // [1, 2, 3, 4, 5]
2.UpTo(1).ToArray(); // []
```

*`UpTo` returns an `IEnumerable<T>`, so you can easily use Linq methods with it.*
