using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class PensionaryContext : DbContext
{
    public PensionaryContext()
    {
    }

    public PensionaryContext(DbContextOptions<PensionaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmploymentType> EmploymentTypes { get; set; }

    public virtual DbSet<Pay> Pays { get; set; }

    public virtual DbSet<PayItem> PayItems { get; set; }

    public virtual DbSet<PayItemType> PayItemTypes { get; set; }

    public virtual DbSet<Pensionary> Pensionaries { get; set; }

    public virtual DbSet<PensionaryComplementary> PensionaryComplementaries { get; set; }

    public virtual DbSet<PensionaryStatus> PensionaryStatuses { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<RetirementStatement> RetirementStatements { get; set; }

    public virtual DbSet<RetirementStatementAmount> RetirementStatementAmounts { get; set; }

    public virtual DbSet<RetirementStatementItem> RetirementStatementItems { get; set; }

    public virtual DbSet<RetirementStatementRelated> RetirementStatementRelateds { get; set; }

    public virtual DbSet<TbGroup> TbGroups { get; set; }

    public virtual DbSet<TbGroupItem> TbGroupItems { get; set; }

    public virtual DbSet<TbGroupUser> TbGroupUsers { get; set; }

    public virtual DbSet<TbItem> TbItems { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbretirementStatementState> TbretirementStatementStates { get; set; }

    public virtual DbSet<TbretirementStatementWf> TbretirementStatementWfs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=84.241.12.49;Database=Pensionary;User ID=sa;Password=zxcv/1400;trustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmploymentType>(entity =>
        {
            entity.HasKey(e => e.EmploymentTypeId).HasName("PK__employme__064E67DFAD6F71A7");

            entity.ToTable("employmentType");

            entity.Property(e => e.EmploymentTypeId)
                .HasDefaultValueSql("(newid())")
                .HasComment("نوع استخدام")
                .HasColumnName("employmentTypeID");
            entity.Property(e => e.EmploymentTypeName)
                .HasMaxLength(50)
                .HasComment("نوع استخدام")
                .HasColumnName("employmentTypeName");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");
        });

        modelBuilder.Entity<Pay>(entity =>
        {
            entity.ToTable("pay");

            entity.Property(e => e.PayId)
                .HasDefaultValueSql("(newid())")
                .HasComment("شناسه پرداخت حقوق")
                .HasColumnName("payID");
            entity.Property(e => e.CurrentMonthId)
                .HasComment("شناسه ماه پرداخت حقوق")
                .HasColumnName("currentMonthID");
            entity.Property(e => e.CurrentYearId)
                .HasComment("سال مالی پرداخت حقوق")
                .HasColumnName("currentYearID");
            entity.Property(e => e.HeirId)
                .HasComment("شناسه وظیفه بگیر گیرنده حقوق")
                .HasColumnName("HeirID");
            entity.Property(e => e.InsertTime)
                .HasComment("زمان ایجاد")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId)
                .HasComment("شناسه کاربر ایجاد کننده")
                .HasColumnName("insertUserID");
            entity.Property(e => e.PayAccount)
                .HasMaxLength(30)
                .HasComment("شماره حساب گیرنده حقوق")
                .HasColumnName("payAccount");
            entity.Property(e => e.PayAmount)
                .HasComment("مبلغ کلی این حقوق")
                .HasColumnType("money")
                .HasColumnName("payAmount");
            entity.Property(e => e.PayConfirmDate)
                .HasComment("تاریخ میلادی تایید پرداخت حقوق")
                .HasColumnType("datetime")
                .HasColumnName("payConfirmDate");
            entity.Property(e => e.PayConfirmSolarDate)
                .HasMaxLength(10)
                .HasComment("تاریخ شمسی تایید پرداخت حقوق")
                .HasColumnName("payConfirmSolarDate");
            entity.Property(e => e.PayCreditAmount)
                .HasComment("مبلغ بستانکار در این حقوق")
                .HasColumnType("money")
                .HasColumnName("payCreditAmount");
            entity.Property(e => e.PayDate)
                .HasComment("تاریخ میلادی پرداخت حقوق")
                .HasColumnType("datetime")
                .HasColumnName("payDate");
            entity.Property(e => e.PayDebitAmount)
                .HasComment("مبلغ بدهکار در این حقوق")
                .HasColumnType("money")
                .HasColumnName("payDebitAmount");
            entity.Property(e => e.PaySolarDate)
                .HasMaxLength(10)
                .HasComment("تاریخ شمسی پرداخت حقوق")
                .HasColumnName("paySolarDate");
            entity.Property(e => e.PensionaryId)
                .HasComment("شناسه مستمری بگیر مرتبط")
                .HasColumnName("PensionaryID");
            entity.Property(e => e.RetiredId)
                .HasComment("شناسه بازنشسته گیرنده حقوق")
                .HasColumnName("RetiredID");
            entity.Property(e => e.RetirementStatementId)
                .HasComment("شناسه حکم بازنشستگی")
                .HasColumnName("retirementStatementID");
            entity.Property(e => e.UpdateTime)
                .HasComment("زمان آخرین ویرایش")
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId)
                .HasComment("شناسه آخرین کاربر ویرایش کننده")
                .HasColumnName("updateUserID");
        });

        modelBuilder.Entity<PayItem>(entity =>
        {
            entity.ToTable("payItem");

            entity.Property(e => e.PayItemId)
                .HasDefaultValueSql("(newid())")
                .HasComment("شناسه آیتم فیش حقوقی")
                .HasColumnName("payItemID");
            entity.Property(e => e.FacilityId)
                .HasComment("شناسه تسهیلات مرتبط")
                .HasColumnName("facilityID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("زمان ایجاد")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId)
                .HasComment("شناسه کاربر ایجاد کننده")
                .HasColumnName("insertUserID");
            entity.Property(e => e.PayId)
                .HasComment("شناسه پرداخت حقوق")
                .HasColumnName("payID");
            entity.Property(e => e.PayItemAmount)
                .HasComment("مبلغ کلی آیتم فیش حقوقی")
                .HasColumnType("money")
                .HasColumnName("payItemAmount");
            entity.Property(e => e.PayItemCreditAmount)
                .HasComment("مبلغ پرداخت آیتم فیش حقوقی")
                .HasColumnType("money")
                .HasColumnName("payItemCreditAmount");
            entity.Property(e => e.PayItemDate)
                .HasComment("زمان میلادی پرداخت آیتم فیش حقوقی")
                .HasColumnType("datetime")
                .HasColumnName("payItemDate");
            entity.Property(e => e.PayItemDebitAmount)
                .HasComment("مبلغ کسر آیتم فیش حقوقی")
                .HasColumnType("money")
                .HasColumnName("payItemDebitAmount");
            entity.Property(e => e.PayItemRemainedAmount)
                .HasComment("مباغ مانده آیتم فیش حقوقی")
                .HasColumnType("money")
                .HasColumnName("payItemRemainedAmount");
            entity.Property(e => e.PayItemSolarDate)
                .HasMaxLength(10)
                .HasComment("زمان شمسی پرداخت آیتم فیش حقوقی")
                .HasColumnName("payItemSolarDate");
            entity.Property(e => e.PayItemTypeId)
                .HasComment("شناسه نوع آیتم فیش حقوقی")
                .HasColumnName("payItemTypeID");
            entity.Property(e => e.UpdateTime)
                .HasComment("زمان آخرین ویرایش")
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId)
                .HasComment("شناسه آخرین کاربر ویرایش کننده")
                .HasColumnName("updateUserID");

            entity.HasOne(d => d.Pay).WithMany(p => p.PayItems)
                .HasForeignKey(d => d.PayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_payItem_payItem");

            entity.HasOne(d => d.PayItemType).WithMany(p => p.PayItems)
                .HasForeignKey(d => d.PayItemTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_payItem_payItemType");
        });

        modelBuilder.Entity<PayItemType>(entity =>
        {
            entity.ToTable("payItemType");

            entity.Property(e => e.PayItemTypeId)
                .HasDefaultValueSql("(newid())")
                .HasComment("شناسه نوع آیتم حقوقی")
                .HasColumnName("payItemTypeID");
            entity.Property(e => e.FacilityTypeId)
                .HasComment("شناسه نوع تسهیلات مرتبط با این آیتم")
                .HasColumnName("facilityTypeID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("زمان ایجاد")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId)
                .HasComment("شناسه کاربر ایجاد کننده")
                .HasColumnName("insertUserID");
            entity.Property(e => e.PayItemTypeIsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("نوع آیتم حقوقی فعال است")
                .HasColumnName("payItemTypeIsActive");
            entity.Property(e => e.PayItemTypeIsCredit)
                .HasComment("نوع آیتم حقوقی پرداخت است")
                .HasColumnName("payItemTypeIsCredit");
            entity.Property(e => e.PayItemTypeIsInsuranceBase)
                .HasComment("این آیتم مبنای محاسبات بیمه است")
                .HasColumnName("payItemTypeIsInsuranceBase");
            entity.Property(e => e.PayItemTypeName)
                .HasMaxLength(50)
                .HasComment("نام نوع آیتم حقوقی")
                .HasColumnName("payItemTypeName");
            entity.Property(e => e.UpdateTime)
                .HasComment("زمان آخرین ویرایش")
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId)
                .HasComment("شناسه آخرین کاربر ویرایش کننده")
                .HasColumnName("updateUserID");
        });

        modelBuilder.Entity<Pensionary>(entity =>
        {
            entity.HasKey(e => e.PensionaryId).HasName("PK__Pensiona__F7ACAD33082B5D52");

            entity.ToTable("pensionary");

            entity.Property(e => e.PensionaryId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("pensionaryID");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(30)
                .HasColumnName("accountNo");
            entity.Property(e => e.BankBranchId).HasColumnName("bankBranchID");
            entity.Property(e => e.BankId).HasColumnName("bankID");
            entity.Property(e => e.EmploymentTypeId).HasColumnName("employmentTypeID");
            entity.Property(e => e.HeirId).HasColumnName("heirID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.InsuranceCoef).HasColumnName("insuranceCoef");
            entity.Property(e => e.LedgerCode).HasColumnName("ledgerCode");
            entity.Property(e => e.ParentPersonId).HasColumnName("parentPersonID");
            entity.Property(e => e.PensionaryFinishSolarDate)
                .HasMaxLength(10)
                .HasColumnName("pensionaryFinishSolarDate");
            entity.Property(e => e.PensionaryFinishdate)
                .HasColumnType("datetime")
                .HasColumnName("pensionaryFinishdate");
            entity.Property(e => e.PensionaryIsActive).HasColumnName("pensionaryIsActive");
            entity.Property(e => e.PensionaryStartSolarDate)
                .HasMaxLength(10)
                .HasColumnName("pensionaryStartSolarDate");
            entity.Property(e => e.PensionaryStartdate)
                .HasColumnType("datetime")
                .HasColumnName("pensionaryStartdate");
            entity.Property(e => e.PensionaryStatusId).HasColumnName("pensionaryStatusID");
            entity.Property(e => e.PersonId).HasColumnName("personID");
            entity.Property(e => e.PersonnelId).HasColumnName("personnelID");
            entity.Property(e => e.RelatedId).HasColumnName("relatedID");
            entity.Property(e => e.RelationshipWithParentId).HasColumnName("relationshipWithParentID");
            entity.Property(e => e.RetiredId).HasColumnName("retiredID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");

            entity.HasOne(d => d.EmploymentType).WithMany(p => p.Pensionaries)
                .HasForeignKey(d => d.EmploymentTypeId)
                .HasConstraintName("FK_pensionary_employmentType");

            entity.HasOne(d => d.ParentPerson).WithMany(p => p.PensionaryParentPeople)
                .HasForeignKey(d => d.ParentPersonId)
                .HasConstraintName("FK_pensionary_parentperson");

            entity.HasOne(d => d.PensionaryStatus).WithMany(p => p.Pensionaries)
                .HasForeignKey(d => d.PensionaryStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pensionary_pensionaryStatus");

            entity.HasOne(d => d.Person).WithMany(p => p.PensionaryPeople)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_pensionary_person");
        });

        modelBuilder.Entity<PensionaryComplementary>(entity =>
        {
            entity.HasKey(e => e.PensionaryComplementaryId).HasName("PK__Pensiona__FF8F117DFC2ED001");

            entity.ToTable("pensionaryComplementary");

            entity.Property(e => e.PensionaryComplementaryId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("pensionaryComplementaryID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.PersonId).HasColumnName("personID");
            entity.Property(e => e.RetiredCardCode)
                .HasMaxLength(20)
                .HasColumnName("retiredCardCode");
            entity.Property(e => e.RetiredGrantDuration).HasColumnName("retiredGrantDuration");
            entity.Property(e => e.RetiredGroup).HasColumnName("retiredGroup");
            entity.Property(e => e.RetiredJobDegreeCoef).HasColumnName("retiredJobDegreeCoef");
            entity.Property(e => e.RetiredLastPosition)
                .HasMaxLength(50)
                .HasColumnName("retiredLastPosition");
            entity.Property(e => e.RetiredOrganizationId).HasColumnName("retiredOrganizationID");
            entity.Property(e => e.RetiredRealDuration).HasColumnName("retiredRealDuration");
            entity.Property(e => e.RetirementDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementDate");
            entity.Property(e => e.RetirementSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementSolarDate");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");

            entity.HasOne(d => d.Person).WithMany(p => p.PensionaryComplementaries)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pensionaryComplementary_person");
        });

        modelBuilder.Entity<PensionaryStatus>(entity =>
        {
            entity.HasKey(e => e.PensionaryStatusId).HasName("PK__Pensiona__0661AA4CDD1F7DBA");

            entity.ToTable("pensionaryStatus");

            entity.Property(e => e.PensionaryStatusId)
                .ValueGeneratedNever()
                .HasComment("وضعیت مستمری بگیر")
                .HasColumnName("pensionaryStatusID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.PensionaryStatusIsDead)
                .HasComment("این وضعیت مستمری بگیر برای فوتی هاست")
                .HasColumnName("pensionaryStatusIsDead");
            entity.Property(e => e.PensionaryStatusIsFirst)
                .HasComment("این وضعیت مستمری بگیر اول می آید")
                .HasColumnName("pensionaryStatusIsFirst");
            entity.Property(e => e.PensionaryStatusIsLockedForPayment)
                .HasComment(" این وضعیت مستمری بگیری حقوق دریافت نمی کند")
                .HasColumnName("pensionaryStatusIsLockedForPayment");
            entity.Property(e => e.PensionaryStatusName)
                .HasMaxLength(50)
                .HasComment("وضعیت مستمری بگیر")
                .HasColumnName("pensionaryStatusName");
            entity.Property(e => e.PensionayStatusCategory)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("R=retired,L=related,H=heir,P=personnel  دسته بندی وضعیت مستمری بگیر")
                .HasColumnName("pensionayStatusCategory");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__person__AA2FFB8529918FBF");

            entity.ToTable("person");

            entity.Property(e => e.PersonId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("personID");
            entity.Property(e => e.EducationTypeId).HasColumnName("educationTypeID");
            entity.Property(e => e.GenderId).HasColumnName("genderID");
            entity.Property(e => e.HousingTypeId).HasColumnName("housingTypeID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.MaritalStatusId).HasColumnName("maritalStatusID");
            entity.Property(e => e.PersonAddress)
                .HasMaxLength(270)
                .HasColumnName("personAddress");
            entity.Property(e => e.PersonArea).HasColumnName("personArea");
            entity.Property(e => e.PersonBirthPlace)
                .HasMaxLength(50)
                .HasColumnName("personBirthPlace");
            entity.Property(e => e.PersonBirthSolarDate)
                .HasMaxLength(10)
                .HasColumnName("personBirthSolarDate");
            entity.Property(e => e.PersonBirthdate)
                .HasColumnType("datetime")
                .HasColumnName("personBirthdate");
            entity.Property(e => e.PersonCellPhone)
                .HasMaxLength(50)
                .HasColumnName("personCellPhone");
            entity.Property(e => e.PersonCellPhone2)
                .HasMaxLength(50)
                .HasColumnName("personCellPhone2");
            entity.Property(e => e.PersonCertificatetNo)
                .HasMaxLength(20)
                .HasColumnName("personCertificatetNo");
            entity.Property(e => e.PersonCity)
                .HasMaxLength(50)
                .HasColumnName("personCity");
            entity.Property(e => e.PersonCountry)
                .HasMaxLength(50)
                .HasColumnName("personCountry");
            entity.Property(e => e.PersonDeathDate)
                .HasColumnType("datetime")
                .HasColumnName("personDeathDate");
            entity.Property(e => e.PersonDeathSolarDate)
                .HasMaxLength(10)
                .HasColumnName("personDeathSolarDate");
            entity.Property(e => e.PersonDescription)
                .HasMaxLength(300)
                .HasColumnName("personDescription");
            entity.Property(e => e.PersonEmail)
                .HasMaxLength(80)
                .HasColumnName("personEmail");
            entity.Property(e => e.PersonFatherName)
                .HasMaxLength(50)
                .HasColumnName("personFatherName");
            entity.Property(e => e.PersonFirstName)
                .HasMaxLength(50)
                .HasColumnName("personFirstName");
            entity.Property(e => e.PersonIsCaptive).HasColumnName("personIsCaptive");
            entity.Property(e => e.PersonIsChildOfSacrificed).HasColumnName("personIsChildOfSacrificed");
            entity.Property(e => e.PersonIsClubMember).HasColumnName("personIsClubMember");
            entity.Property(e => e.PersonIsSacrificed).HasColumnName("personIsSacrificed");
            entity.Property(e => e.PersonIsSacrificedFamily).HasColumnName("personIsSacrificedFamily");
            entity.Property(e => e.PersonIsValiant).HasColumnName("personIsValiant");
            entity.Property(e => e.PersonIsWarrior).HasColumnName("personIsWarrior");
            entity.Property(e => e.PersonLastName)
                .HasMaxLength(100)
                .HasColumnName("personLastName");
            entity.Property(e => e.PersonNationalCode)
                .HasMaxLength(10)
                .HasColumnName("personNationalCode");
            entity.Property(e => e.PersonPhone)
                .HasMaxLength(50)
                .HasColumnName("personPhone");
            entity.Property(e => e.PersonPostalCode)
                .HasMaxLength(20)
                .HasColumnName("personPostalCode");
            entity.Property(e => e.PersonPreviousName)
                .HasMaxLength(50)
                .HasColumnName("personPreviousName");
            entity.Property(e => e.PersonRegion).HasColumnName("personRegion");
            entity.Property(e => e.PersonSpecialDisease)
                .HasMaxLength(300)
                .HasColumnName("personSpecialDisease");
            entity.Property(e => e.PersonState)
                .HasMaxLength(50)
                .HasColumnName("personState");
            entity.Property(e => e.UniversityId).HasColumnName("universityID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");
        });

        modelBuilder.Entity<RetirementStatement>(entity =>
        {
            entity.HasKey(e => e.RetirementStatementId).HasName("PK__retireme__B1E35656D4987505");

            entity.ToTable("retirementStatement");

            entity.Property(e => e.RetirementStatementId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("retirementStatementID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.PensionaryId).HasColumnName("pensionaryID");
            entity.Property(e => e.PensionaryStatusId).HasColumnName("pensionaryStatusID");
            entity.Property(e => e.RetirementDocumentId).HasColumnName("retirementDocumentID");
            entity.Property(e => e.RetirementStatementDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementStatementDate");
            entity.Property(e => e.RetirementStatementDesc)
                .HasMaxLength(1500)
                .HasColumnName("retirementStatementDesc");
            entity.Property(e => e.RetirementStatementIsLast)
                .HasComment("این حکم آخرین حکم تایید شده بازنشسته است")
                .HasColumnName("retirementStatementIsLast");
            entity.Property(e => e.RetirementStatementIsLockedForPayment)
                .HasDefaultValueSql("((0))")
                .HasComment("این بازنشسته فعلا حقوق نمی گیرد")
                .HasColumnName("retirementStatementIsLockedForPayment");
            entity.Property(e => e.RetirementStatementIssueConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementStatementIssueConfirmDate");
            entity.Property(e => e.RetirementStatementIssueConfirmSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementStatementIssueConfirmSolarDate");
            entity.Property(e => e.RetirementStatementIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementStatementIssueDate");
            entity.Property(e => e.RetirementStatementIssueSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementStatementIssueSolarDate");
            entity.Property(e => e.RetirementStatementNo)
                .HasMaxLength(25)
                .HasColumnName("retirementStatementNo");
            entity.Property(e => e.RetirementStatementPayConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementStatementPayConfirmDate");
            entity.Property(e => e.RetirementStatementPayConfirmSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementStatementPayConfirmSolarDate");
            entity.Property(e => e.RetirementStatementPreIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementStatementPreIssueDate");
            entity.Property(e => e.RetirementStatementPreIssueSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementStatementPreIssueSolarDate");
            entity.Property(e => e.RetirementStatementRedirectDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementStatementRedirectDate");
            entity.Property(e => e.RetirementStatementRedirectSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementStatementRedirectSolarDate");
            entity.Property(e => e.RetirementStatementRelatedCount)
                .HasComment("تعداد وابستگان")
                .HasColumnName("retirementStatementRelatedCount");
            entity.Property(e => e.RetirementStatementRunDate)
                .HasColumnType("datetime")
                .HasColumnName("retirementStatementRunDate");
            entity.Property(e => e.RetirementStatementRunSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementStatementRunSolarDate");
            entity.Property(e => e.RetirementStatementSerial).HasColumnName("retirementStatementSerial");
            entity.Property(e => e.RetirementStatementSolarDate)
                .HasMaxLength(10)
                .HasColumnName("retirementStatementSolarDate");
            entity.Property(e => e.RetirementStatementSpouseCount)
                .HasComment("تعداد همسران")
                .HasColumnName("retirementStatementSpouseCount");
            entity.Property(e => e.RetirementStatementTypeId).HasColumnName("retirementStatementTypeID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");

            entity.HasOne(d => d.Pensionary).WithMany(p => p.RetirementStatements)
                .HasForeignKey(d => d.PensionaryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_retirementStatement_pensionary");

            entity.HasOne(d => d.PensionaryStatus).WithMany(p => p.RetirementStatements)
                .HasForeignKey(d => d.PensionaryStatusId)
                .HasConstraintName("FK_retirementStatement_pensionaryStatus");
        });

        modelBuilder.Entity<RetirementStatementAmount>(entity =>
        {
            entity.HasKey(e => e.RetirementStatementAmountId).HasName("PK__Retireme__990E9C890D8D38E1");

            entity.ToTable("retirementStatementAmount");

            entity.Property(e => e.RetirementStatementAmountId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("retirementStatementAmountID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.RetirementStatementId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("retirementStatementID");
            entity.Property(e => e.RetirementStatementItemAmount)
                .HasColumnType("money")
                .HasColumnName("retirementStatementItemAmount");
            entity.Property(e => e.RetirementStatementItemId).HasColumnName("retirementStatementItemID");
            entity.Property(e => e.RetirementStatementRelatedId).HasColumnName("retirementStatementRelatedID");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");

            entity.HasOne(d => d.RetirementStatement).WithMany(p => p.RetirementStatementAmounts)
                .HasForeignKey(d => d.RetirementStatementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_retirementStatementAmount_retirementStatement");

            entity.HasOne(d => d.RetirementStatementItem).WithMany(p => p.RetirementStatementAmounts)
                .HasForeignKey(d => d.RetirementStatementItemId)
                .HasConstraintName("FK_retirementStatementAmount_retirementStatementItem");

            entity.HasOne(d => d.RetirementStatementRelated).WithMany(p => p.RetirementStatementAmounts)
                .HasForeignKey(d => d.RetirementStatementRelatedId)
                .HasConstraintName("FK_retirementStatementAmount_retirementStatementRelated");
        });

        modelBuilder.Entity<RetirementStatementItem>(entity =>
        {
            entity.HasKey(e => e.RetirementStatementItemId).HasName("PK__Retireme__D50A403AF3440604");

            entity.ToTable("retirementStatementItem");

            entity.Property(e => e.RetirementStatementItemId)
                .HasDefaultValueSql("(newid())")
                .HasComment("آیتم حکم")
                .HasColumnName("retirementStatementItemID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.IsActive)
                .HasComment("این آیتم حکم در حال حاضر برای احکام جدید فعال است")
                .HasColumnName("isActive");
            entity.Property(e => e.IsBasicItem)
                .HasComment("این آیتم حکم از موارد حکم بازنشسته است نه حکم موطف و غیره")
                .HasColumnName("isBasicItem");
            entity.Property(e => e.IsIndependentItem)
                .HasComment("این آیتم حکم مستقل نشان داده می شود و با حقوق مبنا جمع نمی شود")
                .HasColumnName("isIndependentItem");
            entity.Property(e => e.RetirementStatementItemName)
                .HasMaxLength(50)
                .HasComment("آیتم حکم")
                .HasColumnName("retirementStatementItemName");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateTime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");
        });

        modelBuilder.Entity<RetirementStatementRelated>(entity =>
        {
            entity.ToTable("retirementStatementRelated");

            entity.Property(e => e.RetirementStatementRelatedId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("retirementStatementRelatedID");
            entity.Property(e => e.InsertTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("insertTime");
            entity.Property(e => e.InsertUserId).HasColumnName("insertUserID");
            entity.Property(e => e.PensionaryId).HasColumnName("pensionaryID");
            entity.Property(e => e.RetirementStatemenRelatedtIsLockedForPayment)
                .HasDefaultValueSql("((0))")
                .HasComment("این فرد فعلا حقوق نمی گیرد")
                .HasColumnName("retirementStatemenRelatedtIsLockedForPayment");
            entity.Property(e => e.RetirementStatementId).HasColumnName("retirementStatementID");
            entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            entity.Property(e => e.UpdateUserId).HasColumnName("updateUserID");

            entity.HasOne(d => d.Pensionary).WithMany(p => p.RetirementStatementRelateds)
                .HasForeignKey(d => d.PensionaryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_retirementStatementRelated_pensionary");

            entity.HasOne(d => d.RetirementStatement).WithMany(p => p.RetirementStatementRelateds)
                .HasForeignKey(d => d.RetirementStatementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_retirementStatementRelated_retirementStatement");
        });

        modelBuilder.Entity<TbGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("tbGroup");

            entity.Property(e => e.GroupId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("groupID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.CreateUserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("createUserID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("editDate");
            entity.Property(e => e.EditUserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("editUserID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .HasColumnName("groupName");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
        });

        modelBuilder.Entity<TbGroupItem>(entity =>
        {
            entity.HasKey(e => e.GroupItemId);

            entity.ToTable("tbGroup_Item");

            entity.Property(e => e.GroupItemId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("groupItemID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.CreateUserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("createUserID");
            entity.Property(e => e.FKGroupId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("fK_GroupID");
            entity.Property(e => e.FKItemId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("fK_ItemID");

            entity.HasOne(d => d.FKGroup).WithMany(p => p.TbGroupItems)
                .HasForeignKey(d => d.FKGroupId)
                .HasConstraintName("FK_tbGroup_Item_tbGroup");

            entity.HasOne(d => d.FKItem).WithMany(p => p.TbGroupItems)
                .HasForeignKey(d => d.FKItemId)
                .HasConstraintName("FK_tbGroup_Item_tbItem");
        });

        modelBuilder.Entity<TbGroupUser>(entity =>
        {
            entity.HasKey(e => e.GroupUserId);

            entity.ToTable("tbGroup_User");

            entity.Property(e => e.GroupUserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("groupUserID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.CreateUserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("createUserID");
            entity.Property(e => e.FKGroupId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("fK_GroupID");
            entity.Property(e => e.FKUserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("fK_UserID");

            entity.HasOne(d => d.FKGroup).WithMany(p => p.TbGroupUsers)
                .HasForeignKey(d => d.FKGroupId)
                .HasConstraintName("FK_tbGroup_User_tbGroup");

            entity.HasOne(d => d.FKUser).WithMany(p => p.TbGroupUsers)
                .HasForeignKey(d => d.FKUserId)
                .HasConstraintName("FK_tbGroup_User_tbUser");
        });

        modelBuilder.Entity<TbItem>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("tbItem");

            entity.Property(e => e.ItemId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("itemID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("className");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .HasColumnName("itemName");
            entity.Property(e => e.ItemStaus).HasColumnName("itemStaus");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tbUser");

            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("userID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("createUser");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("editDate");
            entity.Property(e => e.EditUser)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("editUser");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FNameP)
                .HasMaxLength(100)
                .HasColumnName("fNameP");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LNameP)
                .HasMaxLength(100)
                .HasColumnName("lNameP");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .HasColumnName("password");
            entity.Property(e => e.Sex).HasColumnName("sex");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TbretirementStatementState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbretirementStatementState");

            entity.Property(e => e.Accept).HasColumnName("accept");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("id");
            entity.Property(e => e.NextState).HasColumnName("nextState");
            entity.Property(e => e.RetirementStatementId)
                .HasMaxLength(32)
                .HasColumnName("retirementStatementID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("roleName");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.UserId)
                .HasMaxLength(32)
                .HasColumnName("userID");
        });

        modelBuilder.Entity<TbretirementStatementWf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbretirementStatementWF");

            entity.Property(e => e.Condition)
                .HasMaxLength(50)
                .HasColumnName("condition");
            entity.Property(e => e.ConditionValue).HasColumnName("conditionValue");
            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.NextState).HasColumnName("nextState");
            entity.Property(e => e.Page)
                .HasMaxLength(50)
                .HasColumnName("page");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.StateMessage)
                .HasMaxLength(1000)
                .HasColumnName("stateMessage");
            entity.Property(e => e.StateName)
                .HasMaxLength(100)
                .HasColumnName("stateName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
