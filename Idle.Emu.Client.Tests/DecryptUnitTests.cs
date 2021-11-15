using System;
using System.Collections.Generic;
using System.Linq;
using Cocos.Zip.Services;
using Idle.Emu.Apk;
using Xunit;

namespace Idle.Emu.Client.Tests
{
    public class DecryptUnitTests
    {
        [Fact]
        public void DecryptAllFiles_Success()
        {
            // arrange
            var id = new IdleClient();
            var files = ZipService.ReadFiles(ApkConst.Apk, new List<string>() {".lua", ".png"});
            
            // act
            foreach (var (_, content) in files.Take(50).ToArray())
            {
                var cmp = id.Decrypt(Array.Empty<byte>(), content);
                
                // assert
                Assert.NotNull(cmp.PostDecrypt);
                Assert.NotEmpty(cmp.PostDecrypt);
            }
        }
    }
}