﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KGP.Direct3D11.Textures;
using KGP.Frames;
using KGP.Direct3D11.Buffers;
using KGP;

namespace KDP.Direct3D11.Tests.Textures
{
    [TestClass]
    public class BodyColorPositionBufferTests : IDisposable
    {
        private SharpDX.Direct3D11.Device device;


        public BodyColorPositionBufferTests()
        {
            device = new SharpDX.Direct3D11.Device(SharpDX.Direct3D.DriverType.Reference);
        }

        [TestMethod]
        public void TestCreate()
        {
            using (BodyColorPositionBuffer buffer = new BodyColorPositionBuffer(device))
            {
                Assert.AreNotEqual(buffer.ShaderView.NativePointer, IntPtr.Zero);
            }
        }

        [TestMethod]
        public void TestUploadEmpty()
        {
            using (BodyColorPositionBuffer buffer = new BodyColorPositionBuffer(device))
            {
                ColorSpaceKinectJoints[] empty = new ColorSpaceKinectJoints[0];
                buffer.Copy(device.ImmediateContext, empty);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullDevice()
        {
            using (BodyColorPositionBuffer texture = new BodyColorPositionBuffer(null))
            {
            }
        }

        public void Dispose()
        {
            device.Dispose();
        }
    }
}
