﻿//*****************************************************************************
// File			: UnityGizmoExtensions.cs
// Module		:
// Description	: Extensions to convert between GizmoSDK and Unity3D
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
// AMO	180607	Created file        (2.9.1)
//
//******************************************************************************

// Unity Managed classes
using UnityEngine;

// Gizmo Managed classes
using GizmoSDK.GizmoBase;

namespace Saab.Unity.Extensions
{
    public static class UnityGizmoExtensions
    {
        #region ----- To GizmoSDK --------------------------

        public static Vec3D ToVec3D(this Vector3 vec)
        {
            return new Vec3D(vec.x, vec.y, vec.z);
        }

        public static Vec3 ToVec3(this Vector3 vec)
        {
            return new Vec3(vec.x, vec.y, vec.z);
        }

        public static Matrix4 ToMatrix4(this Matrix4x4 matrix)
        {
            return new Matrix4
            {
                v11 = matrix.m00,
                v12 = matrix.m01,
                v13 = matrix.m02,
                v14 = matrix.m03,

                v21 = matrix.m10,
                v22 = matrix.m11,
                v23 = matrix.m12,
                v24 = matrix.m13,

                v31 = matrix.m20,
                v32 = matrix.m21,
                v33 = matrix.m22,
                v34 = matrix.m23,

                v41 = matrix.m30,
                v42 = matrix.m31,
                v43 = matrix.m32,
                v44 = matrix.m33,
            };
        }

        #endregion



        #region ----- To Unity --------------------------

        public static Vector3 ToVector3(this Vec3D vec)
        {
            return new Vector3((float)vec.x, (float)vec.y, (float)vec.z);
        }
        public static Vector3 ToVector3(this Vec3 vec)
        {
            return new Vector3(vec.x, vec.y, vec.z);
        }

        public static Matrix4x4 ToMatrix4x4(this Matrix4 matrix)
        {
            return new Matrix4x4 
            {
                m00 = matrix.v11,
                m01 = matrix.v12,
                m02 = matrix.v13,
                m03 = matrix.v14,

                m10 = matrix.v21,
                m11 = matrix.v22,
                m12 = matrix.v23,
                m13 = matrix.v24,

                m20 = matrix.v31,
                m21 = matrix.v32,
                m22 = matrix.v33,
                m23 = matrix.v34,

                m30 = matrix.v41,
                m31 = matrix.v42,
                m32 = matrix.v43,
                m33 = matrix.v44
            };
        }

        #endregion
    }
}
