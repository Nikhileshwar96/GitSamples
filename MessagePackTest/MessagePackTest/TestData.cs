using System;
using MessagePack;

namespace MessagePackTest
{
    [MessagePackObject]
    public class TestData
    {
        [Key("test")]
        public string Test { get; set; }
    }
}
