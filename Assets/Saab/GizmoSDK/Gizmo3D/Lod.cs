﻿//******************************************************************************
// File			: Lod.cs
// Module		: Gizmo3D C#
// Description	: C# Bridge to gzLod class
// Author		: Anders Modén		
// Product		: Gizmo3D 2.10.1
//		
// Copyright © 2003- Saab Training Systems AB, Sweden
//			
// NOTE:	Gizmo3D is a high performance 3D Scene Graph and effect visualisation 
//			C++ toolkit for Linux, Mac OS X, Windows (Win32) and IRIX® for  
//			usage in Game or VisSim development.
//
//
// Revision History...							
//									
// Who	Date	Description						
//									
// AMO	180301	Created file 	
//
//******************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GizmoSDK.GizmoBase;


namespace GizmoSDK
{
    namespace Gizmo3D
    {
        public class Lod : Group
        {
            public Lod(IntPtr nativeReference) : base(nativeReference) { }

            public Lod(string name="") : base(Lod_create(name)) { }

            public new static void InitializeFactory()
            {
                AddFactory(new Lod());
            }

            public new static void UnInitializeFactory()
            {
                RemoveFactory("gzLod");
            }

            public override Reference Create(IntPtr nativeReference)
            {
                return new Lod(nativeReference) as Reference;
            }

            #region Native dll interface ----------------------------------
            [DllImport(Platform.BRIDGE, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
            private static extern IntPtr Lod_create(string name);
            #endregion
        }
    }
}
