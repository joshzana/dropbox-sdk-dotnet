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
    /// <para>The admin role object</para>
    /// </summary>
    public class AdminRole
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AdminRole> Encoder = new AdminRoleEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AdminRole> Decoder = new AdminRoleDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AdminRole" /> class.</para>
        /// </summary>
        public AdminRole()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is User</para>
        /// </summary>
        public bool IsUser
        {
            get
            {
                return this is User;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a User, or <c>null</c>.</para>
        /// </summary>
        public User AsUser
        {
            get
            {
                return this as User;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is LimitedAdmin</para>
        /// </summary>
        public bool IsLimitedAdmin
        {
            get
            {
                return this is LimitedAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a LimitedAdmin, or <c>null</c>.</para>
        /// </summary>
        public LimitedAdmin AsLimitedAdmin
        {
            get
            {
                return this as LimitedAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is SupportAdmin</para>
        /// </summary>
        public bool IsSupportAdmin
        {
            get
            {
                return this is SupportAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a SupportAdmin, or <c>null</c>.</para>
        /// </summary>
        public SupportAdmin AsSupportAdmin
        {
            get
            {
                return this as SupportAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UserManagementAdmin</para>
        /// </summary>
        public bool IsUserManagementAdmin
        {
            get
            {
                return this is UserManagementAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserManagementAdmin, or <c>null</c>.</para>
        /// </summary>
        public UserManagementAdmin AsUserManagementAdmin
        {
            get
            {
                return this as UserManagementAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TeamAdmin</para>
        /// </summary>
        public bool IsTeamAdmin
        {
            get
            {
                return this is TeamAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamAdmin, or <c>null</c>.</para>
        /// </summary>
        public TeamAdmin AsTeamAdmin
        {
            get
            {
                return this as TeamAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AdminRole" />.</para>
        /// </summary>
        private class AdminRoleEncoder : enc.StructEncoder<AdminRole>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AdminRole value, enc.IJsonWriter writer)
            {
                if (value is User)
                {
                    WriteProperty(".tag", "user", writer, enc.StringEncoder.Instance);
                    User.Encoder.EncodeFields((User)value, writer);
                    return;
                }
                if (value is LimitedAdmin)
                {
                    WriteProperty(".tag", "limited_admin", writer, enc.StringEncoder.Instance);
                    LimitedAdmin.Encoder.EncodeFields((LimitedAdmin)value, writer);
                    return;
                }
                if (value is SupportAdmin)
                {
                    WriteProperty(".tag", "support_admin", writer, enc.StringEncoder.Instance);
                    SupportAdmin.Encoder.EncodeFields((SupportAdmin)value, writer);
                    return;
                }
                if (value is UserManagementAdmin)
                {
                    WriteProperty(".tag", "user_management_admin", writer, enc.StringEncoder.Instance);
                    UserManagementAdmin.Encoder.EncodeFields((UserManagementAdmin)value, writer);
                    return;
                }
                if (value is TeamAdmin)
                {
                    WriteProperty(".tag", "team_admin", writer, enc.StringEncoder.Instance);
                    TeamAdmin.Encoder.EncodeFields((TeamAdmin)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AdminRole" />.</para>
        /// </summary>
        private class AdminRoleDecoder : enc.UnionDecoder<AdminRole>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AdminRole" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AdminRole Create()
            {
                return new AdminRole();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AdminRole Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "user":
                        return User.Decoder.DecodeFields(reader);
                    case "limited_admin":
                        return LimitedAdmin.Decoder.DecodeFields(reader);
                    case "support_admin":
                        return SupportAdmin.Decoder.DecodeFields(reader);
                    case "user_management_admin":
                        return UserManagementAdmin.Decoder.DecodeFields(reader);
                    case "team_admin":
                        return TeamAdmin.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The user object</para>
        /// </summary>
        public sealed class User : AdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<User> Encoder = new UserEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<User> Decoder = new UserDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="User" /> class.</para>
            /// </summary>
            private User()
            {
            }

            /// <summary>
            /// <para>A singleton instance of User</para>
            /// </summary>
            public static readonly User Instance = new User();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="User" />.</para>
            /// </summary>
            private class UserEncoder : enc.StructEncoder<User>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(User value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="User" />.</para>
            /// </summary>
            private class UserDecoder : enc.StructDecoder<User>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="User" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override User Create()
                {
                    return User.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The limited admin object</para>
        /// </summary>
        public sealed class LimitedAdmin : AdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<LimitedAdmin> Encoder = new LimitedAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<LimitedAdmin> Decoder = new LimitedAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="LimitedAdmin" />
            /// class.</para>
            /// </summary>
            private LimitedAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of LimitedAdmin</para>
            /// </summary>
            public static readonly LimitedAdmin Instance = new LimitedAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="LimitedAdmin" />.</para>
            /// </summary>
            private class LimitedAdminEncoder : enc.StructEncoder<LimitedAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(LimitedAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="LimitedAdmin" />.</para>
            /// </summary>
            private class LimitedAdminDecoder : enc.StructDecoder<LimitedAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="LimitedAdmin" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override LimitedAdmin Create()
                {
                    return LimitedAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The support admin object</para>
        /// </summary>
        public sealed class SupportAdmin : AdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<SupportAdmin> Encoder = new SupportAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<SupportAdmin> Decoder = new SupportAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SupportAdmin" />
            /// class.</para>
            /// </summary>
            private SupportAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of SupportAdmin</para>
            /// </summary>
            public static readonly SupportAdmin Instance = new SupportAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="SupportAdmin" />.</para>
            /// </summary>
            private class SupportAdminEncoder : enc.StructEncoder<SupportAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(SupportAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="SupportAdmin" />.</para>
            /// </summary>
            private class SupportAdminDecoder : enc.StructDecoder<SupportAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="SupportAdmin" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override SupportAdmin Create()
                {
                    return SupportAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The user management admin object</para>
        /// </summary>
        public sealed class UserManagementAdmin : AdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserManagementAdmin> Encoder = new UserManagementAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserManagementAdmin> Decoder = new UserManagementAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserManagementAdmin" />
            /// class.</para>
            /// </summary>
            private UserManagementAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UserManagementAdmin</para>
            /// </summary>
            public static readonly UserManagementAdmin Instance = new UserManagementAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserManagementAdmin" />.</para>
            /// </summary>
            private class UserManagementAdminEncoder : enc.StructEncoder<UserManagementAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserManagementAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserManagementAdmin" />.</para>
            /// </summary>
            private class UserManagementAdminDecoder : enc.StructDecoder<UserManagementAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserManagementAdmin"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserManagementAdmin Create()
                {
                    return UserManagementAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The team admin object</para>
        /// </summary>
        public sealed class TeamAdmin : AdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamAdmin> Encoder = new TeamAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamAdmin> Decoder = new TeamAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamAdmin" /> class.</para>
            /// </summary>
            private TeamAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TeamAdmin</para>
            /// </summary>
            public static readonly TeamAdmin Instance = new TeamAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamAdmin" />.</para>
            /// </summary>
            private class TeamAdminEncoder : enc.StructEncoder<TeamAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamAdmin" />.</para>
            /// </summary>
            private class TeamAdminDecoder : enc.StructDecoder<TeamAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TeamAdmin" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamAdmin Create()
                {
                    return TeamAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
