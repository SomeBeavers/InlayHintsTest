﻿namespace CoreApp;

internal class VS_addFile
{
    public int    I    { get; private set; }
    public string Name { get; private set; } = "";

    private void Test(string s)
    {
    }

    public override string ToString()
    {
        return $"{nameof(I)}: {I}, {nameof(Name)}: {Name}";
    }

    private void UseTest()
    {
        Test(Name);
    }
}