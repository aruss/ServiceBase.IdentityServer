﻿// <auto-generated />
using System;
using IdentityBase.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IdentityBase.EntityFramework.Npgsql.Migrations
{
    [DbContext(typeof(MigrationDbContext))]
    partial class MigrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApiResources");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiResourceClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApiResourceId")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("ApiClaims");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiScope", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApiResourceId")
                        .IsRequired();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApiScopes");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiScopeClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApiScopeId")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeId");

                    b.ToTable("ApiScopeClaims");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiSecret", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApiResourceId")
                        .IsRequired();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("ApiSecrets");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AbsoluteRefreshTokenLifetime");

                    b.Property<int>("AccessTokenLifetime");

                    b.Property<int>("AccessTokenType");

                    b.Property<bool>("AllowAccessTokensViaBrowser");

                    b.Property<bool>("AllowOfflineAccess");

                    b.Property<bool>("AllowPlainTextPkce");

                    b.Property<bool>("AllowRememberConsent");

                    b.Property<bool>("AlwaysIncludeUserClaimsInIdToken");

                    b.Property<bool>("AlwaysSendClientClaims");

                    b.Property<int>("AuthorizationCodeLifetime");

                    b.Property<bool>("BackChannelLogoutSessionRequired");

                    b.Property<string>("BackChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<string>("ClientClaimsPrefix")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ClientName")
                        .HasMaxLength(200);

                    b.Property<string>("ClientUri")
                        .HasMaxLength(2000);

                    b.Property<int?>("ConsentLifetime");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<bool>("EnableLocalLogin");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("FrontChannelLogoutSessionRequired");

                    b.Property<string>("FrontChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<int>("IdentityTokenLifetime");

                    b.Property<bool>("IncludeJwtId");

                    b.Property<string>("LogoUri")
                        .HasMaxLength(2000);

                    b.Property<string>("PairWiseSubjectSalt")
                        .HasMaxLength(200);

                    b.Property<string>("ProtocolType")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("RefreshTokenExpiration");

                    b.Property<int>("RefreshTokenUsage");

                    b.Property<bool>("RequireClientSecret");

                    b.Property<bool>("RequireConsent");

                    b.Property<bool>("RequirePkce");

                    b.Property<int>("SlidingRefreshTokenLifetime");

                    b.Property<bool>("UpdateAccessTokenClaimsOnRefresh");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientClaims");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientCorsOrigin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientCorsOrigins");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientGrantType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("GrantType")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientGrantTypes");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientIdPRestriction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientIdPRestrictions");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientPostLogoutRedirectUri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("PostLogoutRedirectUri")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientPostLogoutRedirectUris");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientProperties");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientRedirectUri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("RedirectUri")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientRedirectUris");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientScope", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientScopes");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientSecret", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClientId")
                        .IsRequired();

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientSecrets");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ExternalAccount", b =>
                {
                    b.Property<Guid>("UserAccountId");

                    b.Property<string>("Provider");

                    b.Property<string>("Subject");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254);

                    b.Property<bool>("IsLoginAllowed");

                    b.Property<DateTime?>("LastLoginAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserAccountId", "Provider", "Subject");

                    b.ToTable("ExternalAccounts");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.IdentityClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("IdentityResourceId")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("IdentityResourceId");

                    b.ToTable("IdentityClaims");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.IdentityResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("IdentityResources");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.UserAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid?>("CreatedBy");

                    b.Property<int>("CreationKind");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254);

                    b.Property<DateTime?>("EmailVerifiedAt");

                    b.Property<int>("FailedLoginCount");

                    b.Property<bool>("IsEmailVerified");

                    b.Property<bool>("IsLoginAllowed");

                    b.Property<DateTime?>("LastFailedLoginAt");

                    b.Property<DateTime?>("LastLoginAt");

                    b.Property<DateTime?>("PasswordChangedAt");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("VerificationKey")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("VerificationKeySentAt");

                    b.Property<int?>("VerificationPurpose");

                    b.Property<string>("VerificationStorage")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.UserAccountClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<Guid>("UserAccountId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("ValueType")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId");

                    b.ToTable("UserAccountClaims");
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiResourceClaim", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.ApiResource", "ApiResource")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiScope", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.ApiResource", "ApiResource")
                        .WithMany("Scopes")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiScopeClaim", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.ApiScope", "ApiScope")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApiScopeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ApiSecret", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.ApiResource", "ApiResource")
                        .WithMany("Secrets")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientClaim", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("Claims")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientCorsOrigin", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("AllowedCorsOrigins")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientGrantType", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("AllowedGrantTypes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientIdPRestriction", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("IdentityProviderRestrictions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientPostLogoutRedirectUri", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("PostLogoutRedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientProperty", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("Properties")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientRedirectUri", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("RedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientScope", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("AllowedScopes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ClientSecret", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.Client", "Client")
                        .WithMany("ClientSecrets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.ExternalAccount", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.UserAccount", "UserAccount")
                        .WithMany("Accounts")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.IdentityClaim", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.IdentityResource", "IdentityResource")
                        .WithMany("UserClaims")
                        .HasForeignKey("IdentityResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IdentityBase.EntityFramework.Entities.UserAccountClaim", b =>
                {
                    b.HasOne("IdentityBase.EntityFramework.Entities.UserAccount", "UserAccount")
                        .WithMany("Claims")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
