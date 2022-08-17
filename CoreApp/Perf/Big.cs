namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}namespace CoreApp;

public class AllTypesOfHints
{
    /// <summary>
    /// </summary>
    /// <param name="parameterMyInnerClass">This is xml doc</param>
    /// <returns></returns>
    public MyInnerClass2 ParameterNameHints(MyInnerClass? parameterMyInnerClass,
        string                                            name,
        int                                               age)
    {
        //return null;
        // missing returns
    }

    public void MissingUsing()
    {
        using var stream = new StreamReader("");
        // missing returns
    }

    public void UseHints()
    {
        // Parameter name hints
        var someLocal = ParameterNameHints(
            null,
            "MyCoolName",
            10);

        // type name hints
        var x = new
        {
        };

        var y = new
        {
            p1 = "",
            p2 = "",
            p3 = ""
        };

        new List<int>().Where(x => x == 1);
        
        new List<MyInnerClass>().Where(x =>
            x.Name.Contains("a")
                .ToString()
                .Equals("")
        );

        var task = new Task(() => { });
        var equals = task
            .AsyncState
            .Equals("");

        // type conversion hints
        ConvertMe(new MyInnerClass());
    }

    public void ConvertMe(MyInnerClass2 myInnerClass2)
    {
    }
}

public class MyInnerClass2
{
}

public class MyInnerClass
{
    public string Name { get; set; }

    public static implicit operator MyInnerClass2(MyInnerClass v)
    {
        return new MyInnerClass2();
    }
}