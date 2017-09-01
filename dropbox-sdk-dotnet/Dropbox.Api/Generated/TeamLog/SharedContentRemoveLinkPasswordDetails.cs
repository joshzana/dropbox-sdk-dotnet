// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Removed the password on the link for the shared file or folder.</para>
    /// </summary>
    public class SharedContentRemoveLinkPasswordDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRemoveLinkPasswordDetails> Encoder = new SharedContentRemoveLinkPasswordDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRemoveLinkPasswordDetails> Decoder = new SharedContentRemoveLinkPasswordDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveLinkPasswordDetails" /> class.</para>
        /// </summary>
        /// <param name="targetAssetIndex">Target asset position in the Assets list.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        /// <param name="sharedFolderType">Shared folder type. Might be missing due to
        /// historical data gap.</param>
        public SharedContentRemoveLinkPasswordDetails(ulong targetAssetIndex,
                                                      string originalFolderName = null,
                                                      string sharedFolderType = null)
        {
            this.TargetAssetIndex = targetAssetIndex;
            this.OriginalFolderName = originalFolderName;
            this.SharedFolderType = sharedFolderType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveLinkPasswordDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRemoveLinkPasswordDetails()
        {
        }

        /// <summary>
        /// <para>Target asset position in the Assets list.</para>
        /// </summary>
        public ulong TargetAssetIndex { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        /// <summary>
        /// <para>Shared folder type. Might be missing due to historical data gap.</para>
        /// </summary>
        public string SharedFolderType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRemoveLinkPasswordDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveLinkPasswordDetailsEncoder : enc.StructEncoder<SharedContentRemoveLinkPasswordDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRemoveLinkPasswordDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_asset_index", value.TargetAssetIndex, writer, enc.UInt64Encoder.Instance);
                if (value.OriginalFolderName != null)
                {
                    WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
                }
                if (value.SharedFolderType != null)
                {
                    WriteProperty("shared_folder_type", value.SharedFolderType, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRemoveLinkPasswordDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveLinkPasswordDetailsDecoder : enc.StructDecoder<SharedContentRemoveLinkPasswordDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedContentRemoveLinkPasswordDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRemoveLinkPasswordDetails Create()
            {
                return new SharedContentRemoveLinkPasswordDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRemoveLinkPasswordDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_asset_index":
                        value.TargetAssetIndex = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_folder_type":
                        value.SharedFolderType = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
