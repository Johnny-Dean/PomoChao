using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITopic 
{
        string t_name {get; set;}
        List<string> tasks {get; set;}
        float time_studied {get; set;}
}
