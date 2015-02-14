﻿using System;
using System.IO;
using HelperLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class UnitTest1 {
        private const string SymlinkPath = @"C:\SymlinkTests\LinkFolder";
        private const string FirstTargetPath = @"C:\SymlinkTests\ExistingFolder";
        private const string SecondTargetPath = @"C:\SymlinkTests\SecondFolder";

        [TestMethod]
        public void Create_And_GetTarget_Symlink() {
            SetupTests();

            ReparsePoint.Create(SymlinkPath, FirstTargetPath, true, ReparsePoint.LinkType.DirectoryLink);
            var measuredTargetPath = ReparsePoint.GetTarget(SymlinkPath);

            Assert.AreEqual(FirstTargetPath, measuredTargetPath, true);
        }

        [TestMethod]
        public void Create_And_Move_Symlink() {
            SetupTests();
            
            var originalFiles = Directory.GetFiles(FirstTargetPath).Length + Directory.GetDirectories(FirstTargetPath).Length;
            var originalTargetFiles = Directory.GetFiles(SecondTargetPath).Length + Directory.GetDirectories(SecondTargetPath).Length;

            ReparsePoint.Create(SymlinkPath, FirstTargetPath, true, ReparsePoint.LinkType.DirectoryLink);
            var doubles = ReparsePoint.Move(SymlinkPath, SecondTargetPath, true, ReparsePoint.LinkType.DirectoryLink);

            var measuredTargetPath = ReparsePoint.GetTarget(SymlinkPath);
            var measuredFiles = Directory.GetFiles(SecondTargetPath).Length + Directory.GetDirectories(SecondTargetPath).Length;

            Assert.AreEqual(SecondTargetPath, measuredTargetPath, true);
            Assert.AreEqual(originalFiles, measuredFiles - originalTargetFiles + doubles);
        }

        [TestMethod]
        public void Delete_Symlink() {
            SetupTests();

            ReparsePoint.Create(SymlinkPath, FirstTargetPath, true, ReparsePoint.LinkType.DirectoryLink);
            ReparsePoint.Delete(SymlinkPath);
            
            Assert.IsFalse(Directory.Exists(SymlinkPath));
        }

        private static void SetupTests() {
            if (!Directory.Exists(FirstTargetPath)) {
                Directory.CreateDirectory(FirstTargetPath);
            }
            if (Directory.GetFiles(FirstTargetPath).Length + Directory.GetDirectories(FirstTargetPath).Length > 0) return;

            // Else, add a file
            var file = File.CreateText(Path.Combine(FirstTargetPath, "testFile.txt"));
            file.Write("TestData");
            file.Close();
        }
    }
}
