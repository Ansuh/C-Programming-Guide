# C# Programming-Guide
_This repository includes the main concepts of C#._

## General Structure of a C# Program
C# programs can consist of one or more files. Each file can contain zero or more namespaces. A namespace can contain types such as classes, structs, interfaces, enumerations, and delegates, in addition to other namespaces. The following is the skeleton of a C# program that contains all of these elements.
``` c#
// A skeleton of a C# program 
using System;
namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface 
    {
    }

    delegate int YourDelegate();

    enum YourEnum 
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct 
        {
        }
    }

    class YourMainClass
    {
        static void Main(string[] args) 
        {
            //Your program starts here...
        }
    }
}
```

Now we will discuss each of this types.

### Class

A class is a construct that enables you to create your own custom types by grouping together variables of other types, methods and events. A class is like a blueprint. It defines the data and behavior of a type. If the class is not declared as static, client code can use it by creating objects or instances which are assigned to a variable. The variable remains in memory until all references to it go out of scope. At that time, the CLR marks it as eligible for garbage collection. If the class is declared as static, then only one copy exists in memory and client code can only access it through the class itself, not an instance variable.

#### Declaring Classes

``` c#
 public class Customer
    {
        //Fields, properties, methods and events go here...
    }
```
The class keyword is preceded by the access level. Because public is used in this case, anyone can create objects from this class. The name of the class follows the class keyword. The remainder of the definition is the class body, where the behavior and data are defined. Fields, properties, methods, and events on a class are collectively referred to as class members.

#### Creating Objects

Although they are sometimes used interchangeably, a class and an object are different things. A class defines a type of object, but it is not an object itself. An object is a concrete entity based on a class, and is sometimes referred to as an instance of a class.
Objects can be created by using the new keyword followed by the name of the class that the object will be based on, like this:
``` c#
Customer object1 = new Customer();
```

When an instance of a class is created, a reference to the object is passed back to the programmer. In the previous example, object1 is a reference to an object that is based on Customer. This reference refers to the new object but does not contain the object data itself. In fact, you can create an object reference without creating an object at all, but it is not recommended creating object references such as this one that does not refer to an object because trying to access an object through such a reference will fail at run time. However, such a reference can be made to refer to an object, either by creating a new object, or by assigning it to an existing object:
``` c#
// not recommended creating of object references
Customer object2;

// recommended creating of object references
Customer object3 = new Customer();
Customer object4 = object3;
```
This code creates two object references that both refer to the same object. Therefore, any changes to the object made through object3 will be reflected in subsequent uses of object4. Because objects that are based on classes are referred to by reference, classes are known as reference types.

#### Class Inheritance

Inheritance is accomplished by using a derivation, which means a class is declared by using a base class from which it inherits data and behavior. A base class is specified by appending a colon and the name of the base class following the derived class name, like this:

``` c#
public class Manager : Employee
    {
        // Employee fields, properties, methods and events are inherited
        // New Manager fields, properties, methods and events go here...
    }
```

When a class declares a base class, it inherits all the members of the base class except the constructors.
a class in C# can only directly inherit from one base class. However, because a base class may itself inherit from another class, a class may indirectly inherit multiple base classes. Furthermore, a class can directly implement more than one interface. 
A class can be declared abstract. An abstract class contains abstract methods that have a signature definition but no implementation. Abstract classes cannot be instantiated. They can only be used through derived classes that implement the abstract methods. By constrast, a sealed class does not allow other classes to derive from it. 
Class definitions can be split between different source files. 


### Structs

Structs are defined by using the struct keyword, for example:

```c#
public struct PostalAddress
    {
        // Fields, properties, methods and events go here...
    }
```










# The Common Type System

Two fundamental points about the type system in the .NET Framework:
- It supports the principle of inheritance. Types can derive from other types, called base types. The derived type inherits (with some restrictions) the methods, properties, and other members of the base type. The base type can in turn derive from some other type, in which case the derived type inherits the members of both base types in its inheritance hierarchy. All types, including built-in numeric types such as System.Int32 (C# keyword: int), derive ultimately from a single base type, which is System.Object (C# keyword: object). This unified type hierarchy is called the Common Type System (CTS). For more information about inheritance in C#, see Inheritance.

- Each type in the CTS is defined as either a value type or a reference type. This includes all custom types in the .NET Framework class library and also your own user-defined types. Types that you define by using the struct keyword are value types; all the built-in numeric types are structs. Types that you define by using the class keyword are reference types. Reference types and value types have different compile-time rules, and different run-time behavior.
The following illustration shows the relationship between value types and reference types in the CTS.

# Inheritance 

Inheritance is one of the three primary characteristics of object-oriented programming. Inheritance enables you to create new classes that reuse, extend, and modify the behavior that is defined in other classes. The class whose members are inherited is called the base class, and the class that inherits those members is called the derived class. A derived class can have only one direct base class. However, inheritance is transitive. If ClassC is derived from ClassB, and ClassB is derived from ClassA, ClassC inherits the members declared in ClassB and ClassA.
Conceptually, a derived class is a specialization of the base class. For example, if you have a base class Animal, you might have one derived class that is named Mammal and another derived class that is named Reptile. A Mammal is an Animal, and a Reptile is an Animal, but each derived class represents different specializations of the base class.

```c#
using System;
namespace InheritanceApplication
{
class Shape 
{
   public void setWidth(int w)
   {
      width = w;
   }
   public void setHeight(int h)
   {
      height = h;
   }
   protected int width;
   protected int height;
}

// Derived class
class Rectangle: Shape
{
   public int getArea()
   { 
      return (width * height); 
   }
}

class RectangleTester
{
   static void Main(string[] args)
   {
      Rectangle Rect = new Rectangle();

      Rect.setWidth(5);
      Rect.setHeight(7);

      // Print the area of the object.
      Console.WriteLine("Total area: {0}",  Rect.getArea());
      Console.ReadKey();
   }
}
}
```


#Exception Class

Represents errors that occur during application execution.


Syntax
C#
```c#
[SerializableAttribute]
[ClassInterfaceAttribute(ClassInterfaceType.None)]
[ComVisibleAttribute(true)]
public class Exception : ISerializable, _Exception
#Exception Handling 
```


A try block is used by C# programmers to partition code that might be affected by an exception. Associated catch blocks are used to handle any resulting exceptions. A finally block contains code that is run regardless of whether or not an exception is thrown in the try block, such as releasing resources that are allocated in the try block. A try block requires one or more associated catch blocks, or a finally block, or both.
The following examples show a try-catch statement, a try-finally statement, and a try-catch-finally statement.

``` c#
 try
            {
                // Code to try goes here.
            }
            catch (SomeSpecificException ex)
            {
                // Code to handle the exception goes here.
                // Only catch exceptions that you know how to handle.
                // Never catch base class System.Exception without
                // rethrowing it at the end of the catch block.
            }
            
            
try
            {
                // Code to try goes here.
            }
            finally
            {
                // Code to execute after the try block goes here.
            }
            
            try
            {
                // Code to try goes here.
            }
            catch (SomeSpecificException ex)
            {
                // Code to handle the exception goes here.
            }
            finally
            {
                // Code to execute after the try (and possibly catch) blocks 
                // goes here.
            }
            
            ```
            
            

