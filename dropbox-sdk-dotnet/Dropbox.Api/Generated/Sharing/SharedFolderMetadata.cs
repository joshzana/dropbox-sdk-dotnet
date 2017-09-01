// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The metadata which includes basic information about the shared folder.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Sharing.SharedFolderMetadataBase" />
    public class SharedFolderMetadata : SharedFolderMetadataBase
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderMetadata> Encoder = new SharedFolderMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderMetadata> Decoder = new SharedFolderMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="accessType">The current user's access level for this shared
        /// folder.</param>
        /// <param name="isInsideTeamFolder">Whether this folder is inside of a team
        /// folder.</param>
        /// <param name="isTeamFolder">Whether this folder is a <a
        /// href="https://www.dropbox.com/en/help/986">team folder</a>.</param>
        /// <param name="name">The name of the this shared folder.</param>
        /// <param name="policy">Policies governing this shared folder.</param>
        /// <param name="previewUrl">URL for displaying a web preview of the shared
        /// folder.</param>
        /// <param name="sharedFolderId">The ID of the shared folder.</param>
        /// <param name="timeInvited">Timestamp indicating when the current user was invited to
        /// this shared folder.</param>
        /// <param name="ownerDisplayNames">The display names of the users that own the folder.
        /// If the folder is part of a team folder, the display names of the team admins are
        /// also included. Absent if the owner display names cannot be fetched.</param>
        /// <param name="ownerTeam">The team that owns the folder. This field is not present if
        /// the folder is not owned by a team.</param>
        /// <param name="parentSharedFolderId">The ID of the parent shared folder. This field
        /// is present only if the folder is contained within another shared folder.</param>
        /// <param name="pathLower">The lower-cased full path of this shared folder. Absent for
        /// unmounted folders.</param>
        /// <param name="linkMetadata">The metadata of the shared content link to this shared
        /// folder. Absent if there is no link on the folder. This is for an unreleased feature
        /// so it may not be returned yet.</param>
        /// <param name="permissions">Actions the current user may perform on the folder and
        /// its contents. The set of permissions corresponds to the FolderActions in the
        /// request.</param>
        public SharedFolderMetadata(AccessLevel accessType,
                                    bool isInsideTeamFolder,
                                    bool isTeamFolder,
                                    string name,
                                    FolderPolicy policy,
                                    string previewUrl,
                                    string sharedFolderId,
                                    sys.DateTime timeInvited,
                                    col.IEnumerable<string> ownerDisplayNames = null,
                                    global::Dropbox.Api.Users.Team ownerTeam = null,
                                    string parentSharedFolderId = null,
                                    string pathLower = null,
                                    SharedContentLinkMetadata linkMetadata = null,
                                    col.IEnumerable<FolderPermission> permissions = null)
            : base(accessType, isInsideTeamFolder, isTeamFolder, ownerDisplayNames, ownerTeam, parentSharedFolderId, pathLower)
        {
            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (policy == null)
            {
                throw new sys.ArgumentNullException("policy");
            }

            if (previewUrl == null)
            {
                throw new sys.ArgumentNullException("previewUrl");
            }

            if (sharedFolderId == null)
            {
                throw new sys.ArgumentNullException("sharedFolderId");
            }
            if (!re.Regex.IsMatch(sharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("sharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
            }

            var permissionsList = enc.Util.ToList(permissions);

            this.Name = name;
            this.Policy = policy;
            this.PreviewUrl = previewUrl;
            this.SharedFolderId = sharedFolderId;
            this.TimeInvited = timeInvited;
            this.LinkMetadata = linkMetadata;
            this.Permissions = permissionsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderMetadata()
        {
        }

        /// <summary>
        /// <para>The name of the this shared folder.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Policies governing this shared folder.</para>
        /// </summary>
        public FolderPolicy Policy { get; protected set; }

        /// <summary>
        /// <para>URL for displaying a web preview of the shared folder.</para>
        /// </summary>
        public string PreviewUrl { get; protected set; }

        /// <summary>
        /// <para>The ID of the shared folder.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        /// <summary>
        /// <para>Timestamp indicating when the current user was invited to this shared
        /// folder.</para>
        /// </summary>
        public sys.DateTime TimeInvited { get; protected set; }

        /// <summary>
        /// <para>The metadata of the shared content link to this shared folder. Absent if
        /// there is no link on the folder. This is for an unreleased feature so it may not be
        /// returned yet.</para>
        /// </summary>
        public SharedContentLinkMetadata LinkMetadata { get; protected set; }

        /// <summary>
        /// <para>Actions the current user may perform on the folder and its contents. The set
        /// of permissions corresponds to the FolderActions in the request.</para>
        /// </summary>
        public col.IList<FolderPermission> Permissions { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderMetadata" />.</para>
        /// </summary>
        private class SharedFolderMetadataEncoder : enc.StructEncoder<SharedFolderMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, global::Dropbox.Api.Sharing.AccessLevel.Encoder);
                WriteProperty("is_inside_team_folder", value.IsInsideTeamFolder, writer, enc.BooleanEncoder.Instance);
                WriteProperty("is_team_folder", value.IsTeamFolder, writer, enc.BooleanEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("policy", value.Policy, writer, global::Dropbox.Api.Sharing.FolderPolicy.Encoder);
                WriteProperty("preview_url", value.PreviewUrl, writer, enc.StringEncoder.Instance);
                WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
                WriteProperty("time_invited", value.TimeInvited, writer, enc.DateTimeEncoder.Instance);
                if (value.OwnerDisplayNames.Count > 0)
                {
                    WriteListProperty("owner_display_names", value.OwnerDisplayNames, writer, enc.StringEncoder.Instance);
                }
                if (value.OwnerTeam != null)
                {
                    WriteProperty("owner_team", value.OwnerTeam, writer, global::Dropbox.Api.Users.Team.Encoder);
                }
                if (value.ParentSharedFolderId != null)
                {
                    WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                }
                if (value.PathLower != null)
                {
                    WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                }
                if (value.LinkMetadata != null)
                {
                    WriteProperty("link_metadata", value.LinkMetadata, writer, global::Dropbox.Api.Sharing.SharedContentLinkMetadata.Encoder);
                }
                if (value.Permissions.Count > 0)
                {
                    WriteListProperty("permissions", value.Permissions, writer, global::Dropbox.Api.Sharing.FolderPermission.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderMetadata" />.</para>
        /// </summary>
        private class SharedFolderMetadataDecoder : enc.StructDecoder<SharedFolderMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderMetadata Create()
            {
                return new SharedFolderMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = global::Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "is_inside_team_folder":
                        value.IsInsideTeamFolder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "is_team_folder":
                        value.IsTeamFolder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "policy":
                        value.Policy = global::Dropbox.Api.Sharing.FolderPolicy.Decoder.Decode(reader);
                        break;
                    case "preview_url":
                        value.PreviewUrl = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "time_invited":
                        value.TimeInvited = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "owner_display_names":
                        value.OwnerDisplayNames = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    case "owner_team":
                        value.OwnerTeam = global::Dropbox.Api.Users.Team.Decoder.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "link_metadata":
                        value.LinkMetadata = global::Dropbox.Api.Sharing.SharedContentLinkMetadata.Decoder.Decode(reader);
                        break;
                    case "permissions":
                        value.Permissions = ReadList<FolderPermission>(reader, global::Dropbox.Api.Sharing.FolderPermission.Decoder);
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
