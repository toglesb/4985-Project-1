﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Description
/// </summary>
///  <author>
/// TJ Oglesby
/// </author>
/// <version>
/// 2/5/15
/// </version>
public class Description
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Description"/> class.
    /// </summary>
	public Description()
	{
		
	}

    public int CustomerID { get; set; }
    public int FeedbackID { get; set; }
    public int ServiceTime { get; set; }
    public int Efficiency { get; set; }
    public int Resolution { get; set; }
    public String Comments { get; set; }
    public bool Contact { get; set; }
    public String ContactMethod { get; set; }
}