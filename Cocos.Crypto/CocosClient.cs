using Cocos.Crypto.Interfaces;

namespace Cocos.Crypto
{
    public sealed class CocosDecryptState
    {
        /// <summary>
        /// key in decoded form
        /// </summary>
        public byte[] Key { get; init; }

        /// <summary>
        /// buffer of pre-decrypt data
        /// </summary>
        public byte[] PreDecrypt { get; init; }

        /// <summary>
        /// buffer of post-decrypt data
        /// </summary>
        public byte[] PostDecrypt { get; init; }
    }

    public sealed class CocosEncryptState
    {
        /// <summary>
        /// key in decoded form
        /// </summary>
        public byte[] Key { get; init; }

        /// <summary>
        /// buffer of pre-encrypt data
        /// </summary>
        public byte[] PreEncrypt { get; init; }

        /// <summary>
        /// buffer of post-encrypt data
        /// </summary>
        public byte[] PostEncrypt { get; init;  }
    }

    public abstract class CocosClient
    {
        private readonly IAlgorithm _algo;
        
        protected CocosClient(IAlgorithm algo)
        {
            _algo = algo;
        }
        
        /// <summary>
        /// pre-process data before decryption like removing headers or any decoding
        /// </summary>
        protected virtual byte[] PreDecrypt(byte[] src)
        {
            return src;
        }

        /// <summary>
        /// post-process data after decryption with e.g decompression
        /// </summary>
        /// <returns></returns>
        protected virtual byte[] PostDecrypt(byte[] src)
        {
            return src;
        }

        /// <summary>
        /// pre-process data before encryption like add any encoding
        /// </summary>
        /// <returns></returns>
        protected virtual byte[] PreEncrypt(byte[] src)
        {
            return src;
        }

        /// <summary>
        /// post-process data after encryption like adding headers
        /// </summary>
        /// <returns></returns>
        protected virtual byte[] PostEncrypt(byte[] data)
        {
            return data;
        }

        /// <summary>
        /// decode key before de/encryption
        /// </summary>
        protected virtual byte[] ProcessKey(byte[] key)
        {
            return key;
        }

        public CocosDecryptState Decrypt(byte[] key, byte[] data)
        {
            var pKey = ProcessKey(key);
            var pData = PreDecrypt(data);

            var decrypted = _algo.Decrypt(pData, pKey);

            return new CocosDecryptState()
            {
                Key = pKey,
                PreDecrypt = pData,
                PostDecrypt = PostDecrypt(decrypted)
            };
        }

        public CocosEncryptState Encrypt(byte[] key, byte[] data)
        {
            var pKey = ProcessKey(key);
            var pData = PreEncrypt(data);

            var encrypted = _algo.Encrypt(pData, pKey);

            return new CocosEncryptState()
            {
                Key = pKey,
                PreEncrypt = pData,
                PostEncrypt = PostEncrypt(encrypted)
            };
        }
    }
}