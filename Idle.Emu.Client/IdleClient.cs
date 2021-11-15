using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cocos.Crypto;
using Cocos.Crypto.Enums;
using Cocos.Crypto.Factories;
using Cocos.Crypto.Interfaces;
using Cocos.Zip.Interfaces;

// ReSharper disable StringLiteralTypo

namespace Idle.Emu.Client
{
      /// <summary>
    /// offsets for 1.127.0.p1
    /// </summary>
    public class IdleClient : CocosClient
    {
        private readonly IZipService _zip = CompressFactory.Create(ECompress.Gzip);
        
        public IdleClient() : base(AlgoFactory.Create(EAlgorithm.Xxtea))
        {
        }
        
        /// <summary>
        /// a ^ b = c
        /// c ^ b = a
        /// </summary>
        private static byte[] XorData(IReadOnlyList<byte> src)
        {
            // byte_C7EC03
            var xorKey = new byte[]
            {
                0x3C, 0xB5, 0x3C, 0x7F, 0x83, 0x94, 0xBA, 0x3B, 0x2B, 0xB2, 0x73, 0x5B, 0xEF, 0xEE, 0xE2, 0xA3, 0x3B,
                0x2B, 0xCC, 0x66, 0x3D, 0xE5, 0x2C, 0xD7, 0x4D, 0x2E, 0x17, 0xE6, 0xF3
            };

            var v10 = 0;
            var buffer = new byte[src.Count];
            for (var i = 0; i < src.Count; ++i)
            {
                var v12 = xorKey[v10++];
                buffer[i] = (byte) (src[i] ^ v12);
                if (v10 == 29) v10 = 7;
            }

            return buffer;
        }
        
        protected override byte[] ProcessKey(byte[] key)
        {
            // NOTE: key from 'applicationDidFinishLaunching()' is a decoy
            
            // byte_C7EC20
            var xorKey = new byte[]
            {
                0x1B, 0xC3, 0xAE, 0xF5, 0x87, 0x8D, 0xAF, 0x3F, 0x2B, 0xC2, 0xD3, 0xFC, 0xFE, 0xE6, 0xF3, 0xA1, 0x3C,
                0x3C, 0xFC, 0xB4, 0x65
            };
            
            var v14 = 0;

            // unk_C28E18; 16 in length
            var v19 = new byte[]
                {0x5f, 0xfa, 0xe7, 0xba, 0xcc, 0xfe, 0xfb, 0x5c, 0x1a, 0xfb, 0xbd, 0xbb, 0x93, 0xb5, 0x83, 0xe7};

            for (var i = 0; i < 16; i++)
            {
                var v16 = xorKey[v14++];
                v19[i] ^= v16;

                if (v14 == 21) v14 = 7;
            }

            return v19; // 0x99E9B4 
        }
        
        #region Encrypt
        protected override byte[] PreEncrypt(byte[] src)
        {
            // compression header
            var header = Encoding.UTF8.GetBytes("DHZAMES");

            // compress src
            src = _zip.Compress(src);

            // header + data
            return header.Concat(src).ToArray();
        }

        protected override byte[] PostEncrypt(byte[] data)
        {
            // encryption header
            var header = Encoding.UTF8.GetBytes("DHGAMES");

            // encode data
            data = XorData(data);

            // header + data
            return header.Concat(data).ToArray();
        }
        #endregion
        
        #region Decrypt
        protected override byte[] PreDecrypt(byte[] src)
        {
            // encryption header
            var header = Encoding.UTF8.GetBytes("DHGAMES");

            // remove header
            src = src.Skip(header.Length).ToArray();

            // decode data
            return XorData(src);
        }

        protected override byte[] PostDecrypt(byte[] src)
        {
            // compression header
            var header = Encoding.UTF8.GetBytes("DHZAMES");

            // remove header
            src = src.Skip(header.Length).ToArray();

            // decompress data
            return _zip.Decompress(src);
        }
        #endregion
        
    }
}