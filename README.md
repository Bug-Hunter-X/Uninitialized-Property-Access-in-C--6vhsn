# Uninitialized Property Access in C# Demo

This repository demonstrates a potential issue in C# where accessing a property before it's explicitly assigned a value might lead to unexpected results rather than throwing an exception.

## The Bug
The `MyProperty` in `MyClass` is never assigned a value before being read in `MyMethod`.  Instead of an error, C# will give you the default value for the property type which is 0 for `int`.

## The Solution
The solution involves explicitly initializing the property in the constructor or before accessing it.