using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MiasHR.Api.Entities;
using MiasHR.Models.DTOs;

namespace MiasHR.Api.Data;

public partial class MiasHRDbContext : DbContext
{
    public MiasHRDbContext()
    {
    }

    public MiasHRDbContext(DbContextOptions<MiasHRDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GbCustomer> GbCustomers { get; set; }

    public virtual DbSet<GbDepartment> GbDepartments { get; set; }

    public virtual DbSet<GbDivision> GbDivisions { get; set; }

    public virtual DbSet<GbOrganization> GbOrganizations { get; set; }

    public virtual DbSet<GbOrganizationNumber> GbOrganizationNumbers { get; set; }

    public virtual DbSet<GbTask> GbTasks { get; set; }

    public virtual DbSet<GbTaskMember> GbTaskMembers { get; set; }

    public virtual DbSet<GbVendor> GbVendors { get; set; }

    public virtual DbSet<HrAssignedProperty> HrAssignedProperties { get; set; }

    public virtual DbSet<HrAutoAccident> HrAutoAccidents { get; set; }

    public virtual DbSet<HrContact> HrContacts { get; set; }

    public virtual DbSet<HrEmployee> HrEmployees { get; set; }

    public virtual DbSet<HrEmployeeAllHistory> HrEmployeeAllHistories { get; set; }

    public virtual DbSet<HrEmployeeApprover> HrEmployeeApprovers { get; set; }

    public virtual DbSet<HrEmployeeCareer> HrEmployeeCareers { get; set; }

    public virtual DbSet<HrEmployeeDetail> HrEmployeeDetails { get; set; }

    public virtual DbSet<HrEmployeeEducation> HrEmployeeEducations { get; set; }

    public virtual DbSet<HrEmployeeHistory> HrEmployeeHistories { get; set; }

    public virtual DbSet<HrEmployeePlan> HrEmployeePlans { get; set; }

    public virtual DbSet<HrEmployeeRp> HrEmployeeRps { get; set; }

    public virtual DbSet<HrEmployeeScanimage> HrEmployeeScanimages { get; set; }

    public virtual DbSet<HrEmployeeSkill> HrEmployeeSkills { get; set; }

    public virtual DbSet<HrEvalBasic> HrEvalBasics { get; set; }

    public virtual DbSet<HrEvalEmployeeResult> HrEvalEmployeeResults { get; set; }

    public virtual DbSet<HrEvalEmployeeSummary> HrEvalEmployeeSummaries { get; set; }

    public virtual DbSet<HrEvalFactor> HrEvalFactors { get; set; }

    public virtual DbSet<HrEvalFactorDetail> HrEvalFactorDetails { get; set; }

    public virtual DbSet<HrEvalFactorMapping> HrEvalFactorMappings { get; set; }

    public virtual DbSet<HrEvalGroup> HrEvalGroups { get; set; }

    public virtual DbSet<HrEvalGroupDept> HrEvalGroupDepts { get; set; }

    public virtual DbSet<HrEvalGroupResult> HrEvalGroupResults { get; set; }

    public virtual DbSet<HrEvalHalfResult> HrEvalHalfResults { get; set; }

    public virtual DbSet<HrEvalHalfResultLog> HrEvalHalfResultLogs { get; set; }

    public virtual DbSet<HrEvalManager> HrEvalManagers { get; set; }

    public virtual DbSet<HrEvalPromotionEmployee> HrEvalPromotionEmployees { get; set; }

    public virtual DbSet<HrEvalSelfResult> HrEvalSelfResults { get; set; }

    public virtual DbSet<HrEvalSelfSummary> HrEvalSelfSummaries { get; set; }

    public virtual DbSet<HrEvalYearResult> HrEvalYearResults { get; set; }

    public virtual DbSet<HrEvalYearResultLog> HrEvalYearResultLogs { get; set; }

    public virtual DbSet<HrGeneralCode> HrGeneralCodes { get; set; }

    public virtual DbSet<HrHoliday> HrHolidays { get; set; }

    public virtual DbSet<HrIncident> HrIncidents { get; set; }

    public virtual DbSet<HrInsEmplPicked> HrInsEmplPickeds { get; set; }

    public virtual DbSet<HrInsEmplSurfing> HrInsEmplSurfings { get; set; }

    public virtual DbSet<HrInsNotEnroll> HrInsNotEnrolls { get; set; }

    public virtual DbSet<HrInsPlan> HrInsPlans { get; set; }

    public virtual DbSet<HrLocker> HrLockers { get; set; }

    public virtual DbSet<HrParkingLot> HrParkingLots { get; set; }

    public virtual DbSet<HrPayroll> HrPayrolls { get; set; }

    public virtual DbSet<HrPayrollBenefit> HrPayrollBenefits { get; set; }

    public virtual DbSet<HrPayrollBonu> HrPayrollBonus { get; set; }

    public virtual DbSet<HrPolicy> HrPolicies { get; set; }

    public virtual DbSet<HrPolicyConsentLog> HrPolicyConsentLogs { get; set; }

    public virtual DbSet<HrPtoForInet> HrPtoForInets { get; set; }

    public virtual DbSet<HrTnaBadge> HrTnaBadges { get; set; }

    public virtual DbSet<HrTnaDay> HrTnaDays { get; set; }

    public virtual DbSet<HrTnaEmailNotice> HrTnaEmailNotices { get; set; }

    public virtual DbSet<HrTnaInout> HrTnaInouts { get; set; }

    public virtual DbSet<HrTnaStartTime> HrTnaStartTimes { get; set; }

    public virtual DbSet<HrTnaTime> HrTnaTimes { get; set; }

    public virtual DbSet<HrTransaction> HrTransactions { get; set; }

    public virtual DbSet<HrVacation> HrVacations { get; set; }

    public virtual DbSet<HrVacation20150707> HrVacation20150707s { get; set; }

    public virtual DbSet<HrWebLoginLog> HrWebLoginLogs { get; set; }

    public virtual DbSet<HrWebMeeting> HrWebMeetings { get; set; }

    public virtual DbSet<HrWebMeetingLog> HrWebMeetingLogs { get; set; }

    public virtual DbSet<HrWebOutside> HrWebOutsides { get; set; }

    public virtual DbSet<HrWebRequest> HrWebRequests { get; set; }

    public virtual DbSet<HrWebUser> HrWebUsers { get; set; }

    public virtual DbSet<IfMpsDetail> IfMpsDetails { get; set; }

    public virtual DbSet<IfMpsEvent> IfMpsEvents { get; set; }

    public virtual DbSet<IfMpsMaster> IfMpsMasters { get; set; }

    public virtual DbSet<IfMpsStage> IfMpsStages { get; set; }

    public virtual DbSet<IfMpsStyle> IfMpsStyles { get; set; }

    public virtual DbSet<IfProcess> IfProcesses { get; set; }

    public virtual DbSet<IfProcessLibrary> IfProcessLibraries { get; set; }

    public virtual DbSet<IfProgress> IfProgresses { get; set; }

    public virtual DbSet<TaCodeMapping> TaCodeMappings { get; set; }

    public virtual DbSet<TaGeneralCode> TaGeneralCodes { get; set; }

    public virtual DbSet<TaPermission> TaPermissions { get; set; }

    public virtual DbSet<TaProgram> TaPrograms { get; set; }

    public virtual DbSet<TaPwConfirmSentence> TaPwConfirmSentences { get; set; }

    public virtual DbSet<TaUser> TaUsers { get; set; }

    public virtual DbSet<TaUserGroup> TaUserGroups { get; set; }

    public virtual DbSet<TaVersion> TaVersions { get; set; }

    public virtual DbSet<TempInsSurf09162022> TempInsSurf09162022s { get; set; }

    public virtual DbSet<TempInsSurf10112018> TempInsSurf10112018s { get; set; }

    public virtual DbSet<TempInsSurfFor2024> TempInsSurfFor2024s { get; set; }

    public virtual DbSet<TempInsurancePlan2024> TempInsurancePlan2024s { get; set; }

    public virtual DbSet<TempInsurePlan2023> TempInsurePlan2023s { get; set; }

    public virtual DbSet<VEmployee> VEmployees { get; set; }

    public virtual DbSet<VwOpIfProcess> VwOpIfProcesses { get; set; }

    public virtual DbSet<VwOpMpsmaster> VwOpMpsmasters { get; set; }

    public virtual DbSet<XxLabel> XxLabels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GbCustomer>(entity =>
        {
            entity.HasKey(e => new { e.CustCode, e.OrgCode }).HasName("PK__GB_CUSTO__B40DCE487F60ED59");

            entity.ToTable("GB_CUSTOMER");

            entity.HasIndex(e => e.OrgCode, "XIF1GB_CUSTOMER");

            entity.Property(e => e.CustCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cust_code");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CustName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cust_name");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsCustId).HasColumnName("mps_cust_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user_code");
        });

        modelBuilder.Entity<GbDepartment>(entity =>
        {
            entity.HasKey(e => new { e.DeptCode, e.OrgCode }).HasName("PK__GB_DEPAR__BF178631339FAB6E");

            entity.ToTable("GB_DEPARTMENT");

            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.AdminYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("admin_yn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DeptLevel).HasColumnName("dept_level");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.DivCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("div_code");
            entity.Property(e => e.ManageEmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("manage_empl_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.QbKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("qb_key");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.SortNo).HasColumnName("sort_no");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StoreYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("store_yn");
            entity.Property(e => e.UpperDeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("upper_dept_code");
        });

        modelBuilder.Entity<GbDivision>(entity =>
        {
            entity.HasKey(e => new { e.DivCode, e.OrgCode }).HasName("PK__GB_DIVIS__BDE6D4CD395884C4");

            entity.ToTable("GB_DIVISION");

            entity.Property(e => e.DivCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("div_code");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.AdminYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("admin_yn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DivLevel).HasColumnName("div_level");
            entity.Property(e => e.DivName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("div_name");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.SortNo).HasColumnName("sort_no");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TreeSortNo).HasColumnName("tree_sort_no");
            entity.Property(e => e.UpperDivCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("upper_div_code");
        });

        modelBuilder.Entity<GbOrganization>(entity =>
        {
            entity.HasKey(e => e.OrgCode).HasName("PK__GB_ORGAN__68B12E5D3F115E1A");

            entity.ToTable("GB_ORGANIZATION");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Homepage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("homepage");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("org_name");
            entity.Property(e => e.OrgType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_type");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.ShortName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("short_name");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TempOrgYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("temp_org_yn");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<GbOrganizationNumber>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Seq }).HasName("PK__GB_ORGAN__956CD596282DF8C2");

            entity.ToTable("GB_ORGANIZATION_NUMBER");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Seq)
                .ValueGeneratedOnAdd()
                .HasColumnName("seq");
            entity.Property(e => e.Class)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ExpireDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("expire_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.No)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("no");
            entity.Property(e => e.NoticeSendDate)
                .HasColumnType("datetime")
                .HasColumnName("notice_send_date");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.StartDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<GbTask>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.TaskCode }).HasName("PK__GB_TASK__0C5C0748693CA210");

            entity.ToTable("GB_TASK");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.TaskCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("task_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EndDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("end_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.StartDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TaskDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("task_desc");
        });

        modelBuilder.Entity<GbTaskMember>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.TaskCode, e.EmplCode }).HasName("PK__GB_TASK___128E2A0A6383C8BA");

            entity.ToTable("GB_TASK_MEMBER");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.TaskCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("task_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<GbVendor>(entity =>
        {
            entity.HasKey(e => new { e.VendCode, e.OrgCode }).HasName("PK__GB_VENDO__40C771430AD2A005");

            entity.ToTable("GB_VENDOR");

            entity.HasIndex(e => e.OrgCode, "XIF1GB_VENDOR");

            entity.Property(e => e.VendCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vend_code");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsVendId).HasColumnName("mps_vend_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user_code");
            entity.Property(e => e.VendName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vend_name");
        });

        modelBuilder.Entity<HrAssignedProperty>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("HR_ASSIGNED_PROPERTY");

            entity.Property(e => e.Seq)
                .ValueGeneratedNever()
                .HasColumnName("seq");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.ClassSn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("class_sn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("manufacturer");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("model");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OtherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("other_name");
            entity.Property(e => e.ProductSn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("product_sn");
            entity.Property(e => e.PropertyType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("property_type");
            entity.Property(e => e.Purpose)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("purpose");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Specification)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("specification");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrAutoAccident>(entity =>
        {
            entity.HasKey(e => e.ManageNo);

            entity.ToTable("HR_AUTO_ACCIDENT");

            entity.Property(e => e.ManageNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("manage_no");
            entity.Property(e => e.AccidentDesc)
                .HasColumnType("text")
                .HasColumnName("accident_desc");
            entity.Property(e => e.AccidentPlace)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accident_place");
            entity.Property(e => e.Ampm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ampm");
            entity.Property(e => e.AutoCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("auto_code");
            entity.Property(e => e.AutoPurpose)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("auto_purpose");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.OtherAutoDesc)
                .HasColumnType("text")
                .HasColumnName("other_auto_desc");
            entity.Property(e => e.OtherLicenseNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("other_license_no");
            entity.Property(e => e.OtherModel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("other_model");
            entity.Property(e => e.OtherName)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("other_name");
            entity.Property(e => e.OtherPlateNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("other_plate_no");
            entity.Property(e => e.OtherTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("other_tel");
            entity.Property(e => e.OtherVinNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("other_vin_no");
            entity.Property(e => e.ReportDate)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("report_date");
            entity.Property(e => e.ReportEmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("report_empl_code");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Time)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("time");
        });

        modelBuilder.Entity<HrContact>(entity =>
        {
            entity.HasKey(e => e.OtherCode).HasName("PK__HR_OTHER__0E0B69A07A672E12");

            entity.ToTable("HR_CONTACT");

            entity.Property(e => e.OtherCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("other_code");
            entity.Property(e => e.Cell)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cell");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OtherType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("other_type");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Tel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tel2");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<HrEmployee>(entity =>
        {
            entity.HasKey(e => e.EmplCode).HasName("PK__HR_EMPLO__14A650FA2DE6D218");

            entity.ToTable("HR_EMPLOYEE");

            entity.HasIndex(e => new { e.OrgCode, e.ActiveYn, e.Status, e.DivCode, e.DeptCode }, "IX_HR_EMPLOYEE_1");

            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ActiveYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("active_yn");
            entity.Property(e => e.BadgeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("badge_code");
            entity.Property(e => e.BuildingLoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("building_loc");
            entity.Property(e => e.BusinessTitle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("business_title");
            entity.Property(e => e.ComEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("com_email");
            entity.Property(e => e.ComFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("com_fax");
            entity.Property(e => e.ComTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("com_tel");
            entity.Property(e => e.ComTelExt)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("com_tel_ext");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.DivCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("div_code");
            entity.Property(e => e.EmplType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_type");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.HireDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("hire_date");
            entity.Property(e => e.HourlybaseYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("hourlybase_yn");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nick_name");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Other)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("other");
            entity.Property(e => e.PayrollCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("payroll_code");
            entity.Property(e => e.PayrollOrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("payroll_org_code");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.PhotoThumbnail)
                .HasColumnType("image")
                .HasColumnName("photo_thumbnail");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PositionYrs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("position_yrs");
            entity.Property(e => e.PtoHireDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("pto_hire_date");
            entity.Property(e => e.QbKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("qb_key");
            entity.Property(e => e.QbSendDate)
                .HasColumnType("datetime")
                .HasColumnName("qb_send_date");
            entity.Property(e => e.ResignDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("resign_date");
            entity.Property(e => e.ResignReason)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resign_reason");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TnaStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tna_status");
            entity.Property(e => e.UpperEmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("upper_empl_code");
        });

        modelBuilder.Entity<HrEmployeeAllHistory>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK__HR_EMPLOYEE_ALL_HISTORY");

            entity.ToTable("HR_EMPLOYEE_ALL_HISTORY");

            entity.HasIndex(e => e.EmplCode, "IX_HR_EMPLOYEE_ALL_HISTORY");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.ActiveYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("active_yn");
            entity.Property(e => e.AlienNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("alien_no");
            entity.Property(e => e.BadgeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("badge_code");
            entity.Property(e => e.BirthDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("birth_date");
            entity.Property(e => e.BuildingLoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("building_loc");
            entity.Property(e => e.BusinessTitle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("business_title");
            entity.Property(e => e.Cell)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cell");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.City2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city2");
            entity.Property(e => e.ComEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("com_email");
            entity.Property(e => e.ComFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("com_fax");
            entity.Property(e => e.ComTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("com_tel");
            entity.Property(e => e.ComTelExt)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("com_tel_ext");
            entity.Property(e => e.Contact1Addr1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact1_addr1");
            entity.Property(e => e.Contact1Addr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact1_addr2");
            entity.Property(e => e.Contact1Cell)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact1_cell");
            entity.Property(e => e.Contact1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact1_name");
            entity.Property(e => e.Contact1Relationship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact1_relationship");
            entity.Property(e => e.Contact1Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact1_tel");
            entity.Property(e => e.Contact2Addr1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact2_addr1");
            entity.Property(e => e.Contact2Addr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact2_addr2");
            entity.Property(e => e.Contact2Cell)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact2_cell");
            entity.Property(e => e.Contact2Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact2_name");
            entity.Property(e => e.Contact2Relationship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact2_relationship");
            entity.Property(e => e.Contact2Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact2_tel");
            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Country2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("country2");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Degree)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("degree");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.DivCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("div_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.EmplType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_type");
            entity.Property(e => e.Exemptions).HasColumnName("exemptions");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.HireDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("hire_date");
            entity.Property(e => e.HourlybaseYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("hourlybase_yn");
            entity.Property(e => e.I9Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("i9_date");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MarriedYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("married_yn");
            entity.Property(e => e.Memo)
                .HasColumnType("text")
                .HasColumnName("memo");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.NickName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nick_name");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.PayrollCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("payroll_code");
            entity.Property(e => e.PayrollOrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("payroll_org_code");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PositionYrs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("position_yrs");
            entity.Property(e => e.PtoHireDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("pto_hire_date");
            entity.Property(e => e.ResidentStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resident_status");
            entity.Property(e => e.ResignDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("resign_date");
            entity.Property(e => e.ResignReason)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resign_reason");
            entity.Property(e => e.Ssn)
                .HasMaxLength(256)
                .HasColumnName("ssn");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.State2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state2");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.Street2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street2");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TnaStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tna_status");
            entity.Property(e => e.W4Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("w4_status");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
            entity.Property(e => e.Zip2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip2");
        });

        modelBuilder.Entity<HrEmployeeApprover>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("HR_EMPLOYEE_APPROVER");

            entity.HasIndex(e => new { e.EmplCode, e.Status }, "IX_HR_EMPLOYEE_APPROVER_1");

            entity.HasIndex(e => new { e.Approver1st, e.Status }, "IX_HR_EMPLOYEE_APPROVER_2");

            entity.HasIndex(e => new { e.Approver2nd, e.Status }, "IX_HR_EMPLOYEE_APPROVER_3");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Approver1st)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approver_1st");
            entity.Property(e => e.Approver2nd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approver_2nd");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OtherManager)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("other_manager");
            entity.Property(e => e.PtoNoticeManager)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pto_notice_manager");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrEmployeeCareer>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq }).HasName("PK__HR_EMPLO__3A4E25C017036CC0");

            entity.ToTable("HR_EMPLOYEE_CAREER");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.FromYyyymm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("from_yyyymm");
            entity.Property(e => e.JobDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("job_desc");
            entity.Property(e => e.LeaveReason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("leave_reason");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Salary)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("salary");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.ToYyyymm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("to_yyyymm");
        });

        modelBuilder.Entity<HrEmployeeDetail>(entity =>
        {
            entity.HasKey(e => e.EmplCode).HasName("PK__HR_EMPLO__14A650FA1CBC4616");

            entity.ToTable("HR_EMPLOYEE_DETAIL");

            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ActiveYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("active_yn");
            entity.Property(e => e.AlienNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("alien_no");
            entity.Property(e => e.BirthDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("birth_date");
            entity.Property(e => e.Cell)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cell");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.City2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city2");
            entity.Property(e => e.Contact1Addr1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact1_addr1");
            entity.Property(e => e.Contact1Addr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact1_addr2");
            entity.Property(e => e.Contact1Cell)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact1_cell");
            entity.Property(e => e.Contact1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact1_name");
            entity.Property(e => e.Contact1Relationship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact1_relationship");
            entity.Property(e => e.Contact1Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact1_tel");
            entity.Property(e => e.Contact2Addr1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact2_addr1");
            entity.Property(e => e.Contact2Addr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact2_addr2");
            entity.Property(e => e.Contact2Cell)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact2_cell");
            entity.Property(e => e.Contact2Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact2_name");
            entity.Property(e => e.Contact2Relationship)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact2_relationship");
            entity.Property(e => e.Contact2Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact2_tel");
            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Country2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("country2");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Degree)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("degree");
            entity.Property(e => e.Exemptions).HasColumnName("exemptions");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.I9Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("i9_date");
            entity.Property(e => e.MarriedYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("married_yn");
            entity.Property(e => e.Memo)
                .HasColumnType("text")
                .HasColumnName("memo");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Other)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("other");
            entity.Property(e => e.ResidentStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resident_status");
            entity.Property(e => e.Ssn)
                .HasMaxLength(256)
                .HasColumnName("ssn");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.State2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state2");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.Street2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street2");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.W4Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("w4_status");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
            entity.Property(e => e.Zip2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip2");
        });

        modelBuilder.Entity<HrEmployeeEducation>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq }).HasName("PK__HR_EMPLO__3A4E25C000200768");

            entity.ToTable("HR_EMPLOYEE_EDUCATION");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EduContent)
                .HasColumnType("text")
                .HasColumnName("edu_content");
            entity.Property(e => e.EduName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("edu_name");
            entity.Property(e => e.EduType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("edu_type");
            entity.Property(e => e.FinishDegree)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("finish_degree");
            entity.Property(e => e.FromDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("from_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.ToDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("to_date");
        });

        modelBuilder.Entity<HrEmployeeHistory>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq }).HasName("PK__HR_EMPLO__3A4E25C005D8E0BE");

            entity.ToTable("HR_EMPLOYEE_HISTORY");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.HistType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hist_type");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.NewCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_code");
            entity.Property(e => e.NewDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("new_desc");
            entity.Property(e => e.OldCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("old_code");
            entity.Property(e => e.OldDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("old_desc");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrEmployeePlan>(entity =>
        {
            entity.HasKey(e => new { e.Yyyymm, e.DeptCode, e.OrgCode }).HasName("PK__HR_EMPLO__66CEDDAE04AFB25B");

            entity.ToTable("HR_EMPLOYEE_PLAN");

            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("yyyymm");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.PlanCnt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("plan_cnt");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<HrEmployeeRp>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq }).HasName("PK__HR_EMPLO__3A4E25C00B91BA14");

            entity.ToTable("HR_EMPLOYEE_RP");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.RpTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rp_title");
            entity.Property(e => e.RpType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rp_type");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrEmployeeScanimage>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq }).HasName("PK__HR_EMPLO__3A4E25C01E05700A");

            entity.ToTable("HR_EMPLOYEE_SCANIMAGE");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.ImageType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("image_type");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<HrEmployeeSkill>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq }).HasName("PK__HR_EMPLO__3A4E25C06EF57B66");

            entity.ToTable("HR_EMPLOYEE_SKILL");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Certificate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("certificate");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Skill)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("skill");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrEvalBasic>(entity =>
        {
            entity.HasKey(e => new { e.Year, e.Term, e.Category, e.Grade, e.OrgCode });

            entity.ToTable("HR_EVAL_BASIC");

            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('a')")
                .HasColumnName("org_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DistributePer).HasColumnName("distribute_per");
            entity.Property(e => e.EvalPer).HasColumnName("eval_per");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.PFrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("p_from");
            entity.Property(e => e.PTo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("p_to");
            entity.Property(e => e.PointFrom)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("point_from");
            entity.Property(e => e.PointTo)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("point_to");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<HrEvalEmployeeResult>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.EmplCode, e.Factor });

            entity.ToTable("HR_EVAL_EMPLOYEE_RESULT");

            entity.HasIndex(e => e.EmplCode, "IX_HR_EVAL_EMPLOYEE_RESULT_1");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Factor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("factor");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.S1FactorPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("s1_factor_point");
            entity.Property(e => e.S1Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("s1_grade");
            entity.Property(e => e.S2FactorPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("s2_factor_point");
            entity.Property(e => e.S2Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("s2_grade");
            entity.Property(e => e.S3FactorPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("s3_factor_point");
            entity.Property(e => e.S3Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("s3_grade");
        });

        modelBuilder.Entity<HrEvalEmployeeSummary>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.EmplCode }).HasName("PK_HR_EVAL_SUMMARY");

            entity.ToTable("HR_EVAL_EMPLOYEE_SUMMARY");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EvalGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("eval_grade");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.GrpEvalPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("grp_eval_point");
            entity.Property(e => e.LateCnt).HasColumnName("late_cnt");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PositionYrs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("position_yrs");
            entity.Property(e => e.S1Comment)
                .HasColumnType("text")
                .HasColumnName("s1_comment");
            entity.Property(e => e.S1EvalGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("s1_eval_grade");
            entity.Property(e => e.S1FactorPoint).HasColumnName("s1_factor_point");
            entity.Property(e => e.S1Point)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("s1_point");
            entity.Property(e => e.S2Comment)
                .HasColumnType("text")
                .HasColumnName("s2_comment");
            entity.Property(e => e.S2EvalGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("s2_eval_grade");
            entity.Property(e => e.S2FactorPoint).HasColumnName("s2_factor_point");
            entity.Property(e => e.S2Point)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("s2_point");
            entity.Property(e => e.S3EvalGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("s3_eval_grade");
            entity.Property(e => e.S3FactorPoint).HasColumnName("s3_factor_point");
            entity.Property(e => e.S3Point)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("s3_point");
            entity.Property(e => e.S4Point)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("s4_point");
            entity.Property(e => e.S5Comment)
                .HasColumnType("text")
                .HasColumnName("s5_comment");
            entity.Property(e => e.S5Point)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("s5_point");
            entity.Property(e => e.TotalPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("total_point");
            entity.Property(e => e.WarningCnt).HasColumnName("warning_cnt");
            entity.Property(e => e.WarningMinutes).HasColumnName("warning_minutes");
        });

        modelBuilder.Entity<HrEvalFactor>(entity =>
        {
            entity.HasKey(e => e.Factor);

            entity.ToTable("HR_EVAL_FACTOR");

            entity.Property(e => e.Factor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("factor");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.FactorDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("factor_desc");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrEvalFactorDetail>(entity =>
        {
            entity.HasKey(e => new { e.Factor, e.FactorGrade });

            entity.ToTable("HR_EVAL_FACTOR_DETAIL");

            entity.Property(e => e.Factor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("factor");
            entity.Property(e => e.FactorGrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("factor_grade");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Point).HasColumnName("point");
        });

        modelBuilder.Entity<HrEvalFactorMapping>(entity =>
        {
            entity.HasKey(e => new { e.Year, e.Term, e.OrgCode, e.GroupCode, e.Factor });

            entity.ToTable("HR_EVAL_FACTOR_MAPPING");

            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.Factor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("factor");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
        });

        modelBuilder.Entity<HrEvalGroup>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.GroupCode });

            entity.ToTable("HR_EVAL_GROUP");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Div)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("div");
            entity.Property(e => e.DivSortNo).HasColumnName("div_sort_no");
            entity.Property(e => e.GroupDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("group_desc");
            entity.Property(e => e.GroupSortNo).HasColumnName("group_sort_no");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Step1Appraiser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("step1_appraiser");
            entity.Property(e => e.Step2Appraiser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("step2_appraiser");
            entity.Property(e => e.Step3Appraiser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("step3_appraiser");
        });

        modelBuilder.Entity<HrEvalGroupDept>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.DeptCode });

            entity.ToTable("HR_EVAL_GROUP_DEPT");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.DeptSortNo).HasColumnName("dept_sort_no");
            entity.Property(e => e.DivCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("div_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
        });

        modelBuilder.Entity<HrEvalGroupResult>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.GroupCode });

            entity.ToTable("HR_EVAL_GROUP_RESULT");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
        });

        modelBuilder.Entity<HrEvalHalfResult>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.EmplCode });

            entity.ToTable("HR_EVAL_HALF_RESULT");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.AdjRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("adj_rate");
            entity.Property(e => e.AvgRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("avg_rate");
            entity.Property(e => e.BOth1Monthly)
                .HasColumnType("money")
                .HasColumnName("b_oth1_monthly");
            entity.Property(e => e.BOth2Monthly)
                .HasColumnType("money")
                .HasColumnName("b_oth2_monthly");
            entity.Property(e => e.BOth3Monthly)
                .HasColumnType("money")
                .HasColumnName("b_oth3_monthly");
            entity.Property(e => e.BPayrollMonthly)
                .HasMaxLength(256)
                .HasColumnName("b_payroll_monthly");
            entity.Property(e => e.Bonus)
                .HasMaxLength(256)
                .HasColumnName("bonus");
            entity.Property(e => e.BonusRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("bonus_rate");
            entity.Property(e => e.BonusTotal)
                .HasMaxLength(256)
                .HasColumnName("bonus_total");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("empl_grade");
            entity.Property(e => e.EmplPer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("empl_per");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.GroupGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("group_grade");
            entity.Property(e => e.GroupPer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("group_per");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Oth1)
                .HasColumnType("money")
                .HasColumnName("oth1");
            entity.Property(e => e.Oth2)
                .HasColumnType("money")
                .HasColumnName("oth2");
            entity.Property(e => e.Oth3)
                .HasColumnType("money")
                .HasColumnName("oth3");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PositionYrs).HasColumnName("position_yrs");
            entity.Property(e => e.ResultRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("result_rate");
        });

        modelBuilder.Entity<HrEvalHalfResultLog>(entity =>
        {
            entity.HasKey(e => new { e.Seq, e.OrgCode, e.Year, e.Term, e.EmplCode });

            entity.ToTable("HR_EVAL_HALF_RESULT_LOG");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.AdjRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("adj_rate");
            entity.Property(e => e.AvgRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("avg_rate");
            entity.Property(e => e.BOth1Monthly)
                .HasColumnType("money")
                .HasColumnName("b_oth1_monthly");
            entity.Property(e => e.BOth2Monthly)
                .HasColumnType("money")
                .HasColumnName("b_oth2_monthly");
            entity.Property(e => e.BOth3Monthly)
                .HasColumnType("money")
                .HasColumnName("b_oth3_monthly");
            entity.Property(e => e.BPayrollMonthly)
                .HasMaxLength(256)
                .HasColumnName("b_payroll_monthly");
            entity.Property(e => e.Bonus)
                .HasMaxLength(256)
                .HasColumnName("bonus");
            entity.Property(e => e.BonusRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("bonus_rate");
            entity.Property(e => e.BonusTotal)
                .HasMaxLength(256)
                .HasColumnName("bonus_total");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("empl_grade");
            entity.Property(e => e.EmplPer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("empl_per");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.GroupGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("group_grade");
            entity.Property(e => e.GroupPer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("group_per");
            entity.Property(e => e.LogDate)
                .HasColumnType("datetime")
                .HasColumnName("log_date");
            entity.Property(e => e.LogUserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("log_user_id");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Oth1)
                .HasColumnType("money")
                .HasColumnName("oth1");
            entity.Property(e => e.Oth2)
                .HasColumnType("money")
                .HasColumnName("oth2");
            entity.Property(e => e.Oth3)
                .HasColumnType("money")
                .HasColumnName("oth3");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PositionYrs).HasColumnName("position_yrs");
            entity.Property(e => e.ResultRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("result_rate");
        });

        modelBuilder.Entity<HrEvalManager>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.EmplCode });

            entity.ToTable("HR_EVAL_MANAGER");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.MgrGroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mgr_group_code");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<HrEvalPromotionEmployee>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.EmplCode });

            entity.ToTable("HR_EVAL_PROMOTION_EMPLOYEE");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.NewPosition)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_position");
            entity.Property(e => e.OldPosition)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("old_position");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<HrEvalSelfResult>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.EmplCode, e.Factor });

            entity.ToTable("HR_EVAL_SELF_RESULT");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Factor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("factor");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.SelfFactorPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("self_factor_point");
            entity.Property(e => e.SelfGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("self_grade");
        });

        modelBuilder.Entity<HrEvalSelfSummary>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.Term, e.EmplCode });

            entity.ToTable("HR_EVAL_SELF_SUMMARY");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.SelfComment)
                .HasColumnType("text")
                .HasColumnName("self_comment");
            entity.Property(e => e.SelfGrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("self_grade");
            entity.Property(e => e.SelfPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("self_point");
        });

        modelBuilder.Entity<HrEvalYearResult>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Year, e.EmplCode });

            entity.ToTable("HR_EVAL_YEAR_RESULT");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.AOth1Annual)
                .HasColumnType("money")
                .HasColumnName("a_oth1_annual");
            entity.Property(e => e.AOth2Annual)
                .HasColumnType("money")
                .HasColumnName("a_oth2_annual");
            entity.Property(e => e.AOth3Annual)
                .HasColumnType("money")
                .HasColumnName("a_oth3_annual");
            entity.Property(e => e.APayrollAnnual)
                .HasMaxLength(256)
                .HasColumnName("a_payroll_annual");
            entity.Property(e => e.AdjRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("adj_rate");
            entity.Property(e => e.AvgRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("avg_rate");
            entity.Property(e => e.BOth1Annual)
                .HasColumnType("money")
                .HasColumnName("b_oth1_annual");
            entity.Property(e => e.BOth2Annual)
                .HasColumnType("money")
                .HasColumnName("b_oth2_annual");
            entity.Property(e => e.BOth3Annual)
                .HasColumnType("money")
                .HasColumnName("b_oth3_annual");
            entity.Property(e => e.BPayrollAnnual)
                .HasMaxLength(256)
                .HasColumnName("b_payroll_annual");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.IncreaseRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("increase_rate");
            entity.Property(e => e.IncreaseTotal)
                .HasMaxLength(256)
                .HasColumnName("increase_total");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Oth1Increase)
                .HasColumnType("money")
                .HasColumnName("oth1_increase");
            entity.Property(e => e.Oth1Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth1_name");
            entity.Property(e => e.Oth1StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth1_start_month");
            entity.Property(e => e.Oth2Increase)
                .HasColumnType("money")
                .HasColumnName("oth2_increase");
            entity.Property(e => e.Oth2Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth2_name");
            entity.Property(e => e.Oth2StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth2_start_month");
            entity.Property(e => e.Oth3Increase)
                .HasColumnType("money")
                .HasColumnName("oth3_increase");
            entity.Property(e => e.Oth3Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth3_name");
            entity.Property(e => e.Oth3StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth3_start_month");
            entity.Property(e => e.PayrollIncrease)
                .HasMaxLength(256)
                .HasColumnName("payroll_increase");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PositionYrs).HasColumnName("position_yrs");
            entity.Property(e => e.PromoRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("promo_rate");
            entity.Property(e => e.ResultRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("result_rate");
            entity.Property(e => e.T1Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("t1_grade");
            entity.Property(e => e.T1Per)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("t1_per");
            entity.Property(e => e.T2Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("t2_grade");
            entity.Property(e => e.T2Per)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("t2_per");
        });

        modelBuilder.Entity<HrEvalYearResultLog>(entity =>
        {
            entity.HasKey(e => new { e.Seq, e.OrgCode, e.Year, e.EmplCode });

            entity.ToTable("HR_EVAL_YEAR_RESULT_LOG");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.AOth1Annual)
                .HasColumnType("money")
                .HasColumnName("a_oth1_annual");
            entity.Property(e => e.AOth2Annual)
                .HasColumnType("money")
                .HasColumnName("a_oth2_annual");
            entity.Property(e => e.AOth3Annual)
                .HasColumnType("money")
                .HasColumnName("a_oth3_annual");
            entity.Property(e => e.APayrollAnnual)
                .HasMaxLength(256)
                .HasColumnName("a_payroll_annual");
            entity.Property(e => e.AdjRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("adj_rate");
            entity.Property(e => e.AvgRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("avg_rate");
            entity.Property(e => e.BOth1Annual)
                .HasColumnType("money")
                .HasColumnName("b_oth1_annual");
            entity.Property(e => e.BOth2Annual)
                .HasColumnType("money")
                .HasColumnName("b_oth2_annual");
            entity.Property(e => e.BOth3Annual)
                .HasColumnType("money")
                .HasColumnName("b_oth3_annual");
            entity.Property(e => e.BPayrollAnnual)
                .HasMaxLength(256)
                .HasColumnName("b_payroll_annual");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.IncreaseRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("increase_rate");
            entity.Property(e => e.IncreaseTotal)
                .HasMaxLength(256)
                .HasColumnName("increase_total");
            entity.Property(e => e.LogDate)
                .HasColumnType("datetime")
                .HasColumnName("log_date");
            entity.Property(e => e.LogUserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("log_user_id");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Oth1Increase)
                .HasColumnType("money")
                .HasColumnName("oth1_increase");
            entity.Property(e => e.Oth1Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth1_name");
            entity.Property(e => e.Oth1StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth1_start_month");
            entity.Property(e => e.Oth2Increase)
                .HasColumnType("money")
                .HasColumnName("oth2_increase");
            entity.Property(e => e.Oth2Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth2_name");
            entity.Property(e => e.Oth2StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth2_start_month");
            entity.Property(e => e.Oth3Increase)
                .HasColumnType("money")
                .HasColumnName("oth3_increase");
            entity.Property(e => e.Oth3Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth3_name");
            entity.Property(e => e.Oth3StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth3_start_month");
            entity.Property(e => e.PayrollIncrease)
                .HasMaxLength(256)
                .HasColumnName("payroll_increase");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PositionYrs).HasColumnName("position_yrs");
            entity.Property(e => e.PromoRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("promo_rate");
            entity.Property(e => e.ResultRate)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("result_rate");
            entity.Property(e => e.T1Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("t1_grade");
            entity.Property(e => e.T1Per)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("t1_per");
            entity.Property(e => e.T2Grade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("t2_grade");
            entity.Property(e => e.T2Per)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("t2_per");
        });

        modelBuilder.Entity<HrGeneralCode>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Class, e.Code }).HasName("PK__HR_GENER__4699A49F6DCC4D03");

            entity.ToTable("HR_GENERAL_CODE");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.Code)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DayHours).HasColumnName("day_hours");
            entity.Property(e => e.Decimal1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("decimal_1");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Number1).HasColumnName("number_1");
            entity.Property(e => e.Number2).HasColumnName("number_2");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.SortNo).HasColumnName("sort_no");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Value1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value_1");
            entity.Property(e => e.Value2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value_2");
            entity.Property(e => e.Value3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value_3");
            entity.Property(e => e.Value4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value_4");
        });

        modelBuilder.Entity<HrHoliday>(entity =>
        {
            entity.HasKey(e => e.Date).HasName("PK__HR_HOLID__D9DE21FC74AE54BC");

            entity.ToTable("HR_HOLIDAY");

            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrIncident>(entity =>
        {
            entity.HasKey(e => e.ManageNo);

            entity.ToTable("HR_INCIDENT");

            entity.Property(e => e.ManageNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("manage_no");
            entity.Property(e => e.AccidentPlace)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accident_place");
            entity.Property(e => e.Ampm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ampm");
            entity.Property(e => e.Call911Yn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("call_911_yn");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.DoctorCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("doctor_code");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.FirstAidYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("first_aid_yn");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.HomeTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("home_tel");
            entity.Property(e => e.HospitalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hospital_code");
            entity.Property(e => e.HospitalYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("hospital_yn");
            entity.Property(e => e.IncidentDesc)
                .HasColumnType("text")
                .HasColumnName("incident_desc");
            entity.Property(e => e.InjuredX)
                .HasDefaultValueSql("((0))")
                .HasColumnName("injured_x");
            entity.Property(e => e.InjuredY)
                .HasDefaultValueSql("((0))")
                .HasColumnName("injured_y");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.OtherTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("other_tel");
            entity.Property(e => e.PersonType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("person_type");
            entity.Property(e => e.ReportedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reported_by");
            entity.Property(e => e.ReportedDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("reported_date");
            entity.Property(e => e.ReviewedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reviewed_by");
            entity.Property(e => e.ReviewedDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("reviewed_date");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.Time)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("time");
            entity.Property(e => e.Witness1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("witness1_name");
            entity.Property(e => e.Witness1Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("witness1_tel");
            entity.Property(e => e.Witness2Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("witness2_name");
            entity.Property(e => e.Witness2Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("witness2_tel");
            entity.Property(e => e.WorkTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("work_tel");
            entity.Property(e => e.WorkcompDesc)
                .HasColumnType("text")
                .HasColumnName("workcomp_desc");
            entity.Property(e => e.WorkcompYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("workcomp_yn");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<HrInsEmplPicked>(entity =>
        {
            entity.HasKey(e => new { e.InsPickedId, e.OrgCode });

            entity.ToTable("HR_INS_EMPL_PICKED");

            entity.HasIndex(e => new { e.EmplCode, e.PlanId, e.Status, e.OrgCode }, "IX_HR_INS_EMPL_PICKED_01");

            entity.HasIndex(e => new { e.SurfingId, e.Status, e.OrgCode }, "IX_HR_INS_EMPL_PICKED_02");

            entity.Property(e => e.InsPickedId).HasColumnName("ins_picked_id");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.BundleYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("bundle_yn");
            entity.Property(e => e.CompanyPayAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("company_pay_amt");
            entity.Property(e => e.Coverage)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("coverage");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DepAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("dep_amt");
            entity.Property(e => e.EeAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("ee_amt");
            entity.Property(e => e.EePayAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("ee_pay_amt");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.PlanId).HasColumnName("plan_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SurfingId).HasColumnName("surfing_id");
            entity.Property(e => e.TotalAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("total_amt");
        });

        modelBuilder.Entity<HrInsEmplSurfing>(entity =>
        {
            entity.HasKey(e => new { e.SurfingId, e.OrgCode });

            entity.ToTable("HR_INS_EMPL_SURFING");

            entity.HasIndex(e => new { e.PlanId, e.EmplCode, e.Status, e.OrgCode }, "IX_HR_INS_EMPL_SURFING_01");

            entity.HasIndex(e => new { e.EmplCode, e.Status, e.OrgCode }, "IX_HR_INS_EMPL_SURFING_02");

            entity.Property(e => e.SurfingId).HasColumnName("surfing_id");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Coverage)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("coverage");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DepAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("dep_amt");
            entity.Property(e => e.EeAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("ee_amt");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OtherEeAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_ee_amt");
            entity.Property(e => e.OtherEeBundleAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_ee_bundle_amt");
            entity.Property(e => e.OtherEechAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_eech_amt");
            entity.Property(e => e.OtherEechBundleAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_eech_bundle_amt");
            entity.Property(e => e.OtherEespAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_eesp_amt");
            entity.Property(e => e.OtherEespBundleAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_eesp_bundle_amt");
            entity.Property(e => e.OtherFamAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_fam_amt");
            entity.Property(e => e.OtherFamBundleAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("other_fam_bundle_amt");
            entity.Property(e => e.PlanId).HasColumnName("plan_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("total_amt");
        });

        modelBuilder.Entity<HrInsNotEnroll>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.StartDate, e.EmplCode, e.PlanType });

            entity.ToTable("HR_INS_NOT_ENROLL");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.PlanType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("plan_type");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
        });

        modelBuilder.Entity<HrInsPlan>(entity =>
        {
            entity.HasKey(e => new { e.PlanId, e.OrgCode });

            entity.ToTable("HR_INS_PLAN");

            entity.Property(e => e.PlanId).HasColumnName("plan_id");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("contract_code");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OpenYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("open_yn");
            entity.Property(e => e.PayRateForDep)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pay_rate_for_dep");
            entity.Property(e => e.PayRateForEe)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pay_rate_for_ee");
            entity.Property(e => e.PlanDesc)
                .HasColumnType("text")
                .HasColumnName("plan_desc");
            entity.Property(e => e.PlanImage)
                .HasColumnType("image")
                .HasColumnName("plan_image");
            entity.Property(e => e.PlanName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("plan_name");
            entity.Property(e => e.PlanType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("plan_type");
            entity.Property(e => e.SortNo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sort_no");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrLocker>(entity =>
        {
            entity.HasKey(e => new { e.LockerGroup, e.Code }).HasName("PK__HR_LOCKER");

            entity.ToTable("HR_LOCKER");

            entity.Property(e => e.LockerGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("locker_group");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.ReserveCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reserve_code");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrParkingLot>(entity =>
        {
            entity.HasKey(e => new { e.LotGroup, e.LotCode }).HasName("PK__HR_PARKING_LOT");

            entity.ToTable("HR_PARKING_LOT");

            entity.Property(e => e.LotGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("lot_group");
            entity.Property(e => e.LotCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("lot_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.LotImage)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("lot_image");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.ReserveCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reserve_code");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrPayroll>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq });

            entity.ToTable("HR_PAYROLL");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Oth1IncreasePer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("oth1_increase_per");
            entity.Property(e => e.Oth1PayrollMonthly)
                .HasColumnType("money")
                .HasColumnName("oth1_payroll_monthly");
            entity.Property(e => e.Oth1PayrollName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth1_payroll_name");
            entity.Property(e => e.Oth1StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth1_start_month");
            entity.Property(e => e.Oth2IncreasePer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("oth2_increase_per");
            entity.Property(e => e.Oth2PayrollMonthly)
                .HasColumnType("money")
                .HasColumnName("oth2_payroll_monthly");
            entity.Property(e => e.Oth2PayrollName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth2_payroll_name");
            entity.Property(e => e.Oth2StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth2_start_month");
            entity.Property(e => e.Oth3IncreasePer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("oth3_increase_per");
            entity.Property(e => e.Oth3PayrollMonthly)
                .HasColumnType("money")
                .HasColumnName("oth3_payroll_monthly");
            entity.Property(e => e.Oth3PayrollName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oth3_payroll_name");
            entity.Property(e => e.Oth3StartMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("oth3_start_month");
            entity.Property(e => e.PayrollAnnual)
                .HasMaxLength(256)
                .HasColumnName("payroll_annual");
            entity.Property(e => e.PayrollBiweekly)
                .HasMaxLength(256)
                .HasColumnName("payroll_biweekly");
            entity.Property(e => e.PayrollHourly)
                .HasMaxLength(256)
                .HasColumnName("payroll_hourly");
            entity.Property(e => e.PayrollIncreasePer)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("payroll_increase_per");
            entity.Property(e => e.PayrollMonthly)
                .HasMaxLength(256)
                .HasColumnName("payroll_monthly");
            entity.Property(e => e.PayrollSemimonthly)
                .HasMaxLength(256)
                .HasColumnName("payroll_semimonthly");
            entity.Property(e => e.PayrollStartDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("payroll_start_date");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrPayrollBenefit>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq });

            entity.ToTable("HR_PAYROLL_BENEFIT");

            entity.HasIndex(e => new { e.PayDate, e.EmplCode }, "IX_HR_PAYROLL_BENEFIT_1");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.AdjustAmt)
                .HasColumnType("money")
                .HasColumnName("adjust_amt");
            entity.Property(e => e.Benefit1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("benefit1");
            entity.Property(e => e.Benefit2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("benefit2");
            entity.Property(e => e.Benefit3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("benefit3");
            entity.Property(e => e.Benefit4)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("benefit4");
            entity.Property(e => e.Benefit5)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("benefit5");
            entity.Property(e => e.BenefitAmt)
                .HasColumnType("money")
                .HasColumnName("benefit_amt");
            entity.Property(e => e.ContType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cont_type");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.PayDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("pay_date");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Remark2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark2");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("total_amt");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("yyyymm");
        });

        modelBuilder.Entity<HrPayrollBonu>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq });

            entity.ToTable("HR_PAYROLL_BONUS");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Bonus)
                .HasMaxLength(256)
                .HasColumnName("bonus");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.PayDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("pay_date");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("term");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        modelBuilder.Entity<HrPolicy>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("HR_POLICY");

            entity.Property(e => e.Seq)
                .ValueGeneratedNever()
                .HasColumnName("seq");
            entity.Property(e => e.ConsentContent)
                .HasColumnType("text")
                .HasColumnName("consent_content");
            entity.Property(e => e.ConsentYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("consent_yn");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Hit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("hit");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.SortNo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sort_no");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<HrPolicyConsentLog>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_HR_Policy_Consent_Log");

            entity.ToTable("HR_POLICY_CONSENT_LOG");

            entity.Property(e => e.Seq)
                .ValueGeneratedNever()
                .HasColumnName("seq");
            entity.Property(e => e.ConsentYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("consent_yn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.PolicySeq).HasColumnName("policy_seq");
        });

        modelBuilder.Entity<HrPtoForInet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_PTO_FOR_INET");

            entity.HasIndex(e => e.UserId, "IX_HR_PTO_FOR_INET_01");

            entity.Property(e => e.CrtDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("crt_date");
            entity.Property(e => e.DayType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("day_type");
            entity.Property(e => e.DayTypeDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("day_type_desc");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.EmplName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empl_name");
            entity.Property(e => e.EndDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("end_date");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.StartDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<HrTnaBadge>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK__HR_TNA_BADGE");

            entity.ToTable("HR_TNA_BADGE");

            entity.HasIndex(e => new { e.Date, e.GroupCode, e.PersonId }, "IX_HR_TNA_BADGE_01");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CardNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("card_no");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("company_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.DepartCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("depart_code");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.Inout)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("inout");
            entity.Property(e => e.PersonId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("person_id");
            entity.Property(e => e.PersonName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("person_name");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("time");
        });

        modelBuilder.Entity<HrTnaDay>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Seq }).HasName("PK__HR_TNA_D__3A4E25C073852659");

            entity.ToTable("HR_TNA_DAY");

            entity.HasIndex(e => new { e.Date, e.OrgCode, e.DayType, e.EmplCode }, "IX_HR_TNA_DAY_1");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.DayType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("day_type");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.StartTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UtoAppliedYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("uto_applied_yn");
        });

        modelBuilder.Entity<HrTnaEmailNotice>(entity =>
        {
            entity.HasKey(e => new { e.EmplCode, e.Date });

            entity.ToTable("HR_TNA_EMAIL_NOTICE");

            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.CrtDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("crt_date");
            entity.Property(e => e.SendDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("send_date");
            entity.Property(e => e.SendUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("send_user");
            entity.Property(e => e.TypeDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type_desc");
        });

        modelBuilder.Entity<HrTnaInout>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.Date, e.Seq }).HasName("PK__HR_TNA_I__3A4E25C07EF6D905");

            entity.ToTable("HR_TNA_INOUT");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.AutoCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("auto_code");
            entity.Property(e => e.AutoYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("auto_yn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.GasCardAmt)
                .HasColumnType("money")
                .HasColumnName("gas_card_amt");
            entity.Property(e => e.GasCardCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gas_card_code");
            entity.Property(e => e.GasCardYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gas_card_yn");
            entity.Property(e => e.InTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("in_time");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OutTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("out_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrTnaStartTime>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("HR_TNA_START_TIME");

            entity.Property(e => e.Seq)
                .ValueGeneratedNever()
                .HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.EndDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((99991231))")
                .HasColumnName("end_date");
            entity.Property(e => e.Fri)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .HasColumnName("fri");
            entity.Property(e => e.LateTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("late_time");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Mon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .HasColumnName("mon");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.StartDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Thu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .HasColumnName("thu");
            entity.Property(e => e.Tue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .HasColumnName("tue");
            entity.Property(e => e.Wed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .HasColumnName("wed");
            entity.Property(e => e.WorkStartTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("work_start_time");
        });

        modelBuilder.Entity<HrTnaTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_TNA_TIME");

            entity.HasIndex(e => new { e.EmplCode, e.OrgCode, e.Date }, "IX_HR_TNA_TIME_1");

            entity.HasIndex(e => new { e.Date, e.LateLevel }, "IX_HR_TNA_TIME_2");

            entity.Property(e => e.BadgeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("badge_code");
            entity.Property(e => e.BadgeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("badge_name");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Date)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.Inout)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('IN')")
                .HasColumnName("inout");
            entity.Property(e => e.LateLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("late_level");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.UpdateReason)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("update_reason");
            entity.Property(e => e.UpdateType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("update_type");
            entity.Property(e => e.WorkEndTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("work_end_time");
            entity.Property(e => e.WorkStartTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("work_start_time");
        });

        modelBuilder.Entity<HrTransaction>(entity =>
        {
            entity.HasKey(e => new { e.TransType, e.OrgCode }).HasName("PK__HR_TRANS__B4E867FA5DCAEF64");

            entity.ToTable("HR_TRANSACTION");

            entity.Property(e => e.TransType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("trans_type");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.CodeLen).HasColumnName("code_len");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.LastNo).HasColumnName("last_no");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
        });

        modelBuilder.Entity<HrVacation>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Yyyy, e.VType, e.Seq }).HasName("PK__HR_VACAT__AC8DCEA15165187F");

            entity.ToTable("HR_VACATION");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Yyyy)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("yyyy");
            entity.Property(e => e.VType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("v_type");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Days)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("days");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.MonthAdjDays)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("monthAdjDays");
            entity.Property(e => e.MonthUsedDays)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("monthUsedDays");
            entity.Property(e => e.PreMonthLeftDays)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("preMonthLeftDays");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.StartDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrVacation20150707>(entity =>
        {
            entity.HasKey(e => new { e.OrgCode, e.EmplCode, e.Yyyy, e.VType, e.Seq }).HasName("PK__HR_VACAT__20150707_AC8DCEA15165187F");

            entity.ToTable("HR_VACATION_20150707");

            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Yyyy)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("yyyy");
            entity.Property(e => e.VType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("v_type");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Days)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("days");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.StartDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrWebLoginLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_WEB_LOGIN_LOG");

            entity.Property(e => e.AcceptYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .HasColumnName("accept_yn");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.LoginDate)
                .HasColumnType("datetime")
                .HasColumnName("login_date");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<HrWebMeeting>(entity =>
        {
            entity.HasKey(e => e.ReqId);

            entity.ToTable("HR_WEB_MEETING");

            entity.Property(e => e.ReqId)
                .ValueGeneratedNever()
                .HasColumnName("req_id");
            entity.Property(e => e.AltMeetingDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("alt_meeting_date");
            entity.Property(e => e.AltMeetingTime).HasColumnName("alt_meeting_time");
            entity.Property(e => e.CloseDate)
                .HasColumnType("datetime")
                .HasColumnName("close_date");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.InCharge)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("in_charge");
            entity.Property(e => e.MeetingAttendance)
                .HasColumnType("text")
                .HasColumnName("meeting_attendance");
            entity.Property(e => e.MeetingContent)
                .HasColumnType("text")
                .HasColumnName("meeting_content");
            entity.Property(e => e.MeetingDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("meeting_date");
            entity.Property(e => e.MeetingTime).HasColumnName("meeting_time");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.ReqContent)
                .HasColumnType("text")
                .HasColumnName("req_content");
            entity.Property(e => e.ReqDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("req_date");
            entity.Property(e => e.ReqMeetingDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("req_meeting_date");
            entity.Property(e => e.ReqMeetingTime).HasColumnName("req_meeting_time");
            entity.Property(e => e.ReqTo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("req_to");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrWebMeetingLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_WEB_MEETING_LOG");

            entity.Property(e => e.AltMeetingDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("alt_meeting_date");
            entity.Property(e => e.AltMeetingTime).HasColumnName("alt_meeting_time");
            entity.Property(e => e.CloseDate)
                .HasColumnType("datetime")
                .HasColumnName("close_date");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.InCharge)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("in_charge");
            entity.Property(e => e.LogDate)
                .HasColumnType("datetime")
                .HasColumnName("log_date");
            entity.Property(e => e.LogType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("log_type");
            entity.Property(e => e.LogUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("log_user");
            entity.Property(e => e.MeetingAttendance)
                .HasColumnType("text")
                .HasColumnName("meeting_attendance");
            entity.Property(e => e.MeetingContent)
                .HasColumnType("text")
                .HasColumnName("meeting_content");
            entity.Property(e => e.MeetingDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("meeting_date");
            entity.Property(e => e.MeetingTime).HasColumnName("meeting_time");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.ReqContent)
                .HasColumnType("text")
                .HasColumnName("req_content");
            entity.Property(e => e.ReqDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("req_date");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.ReqMeetingDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("req_meeting_date");
            entity.Property(e => e.ReqMeetingTime).HasColumnName("req_meeting_time");
            entity.Property(e => e.ReqTo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("req_to");
            entity.Property(e => e.Seq)
                .ValueGeneratedOnAdd()
                .HasColumnName("seq");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrWebOutside>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("HR_WEB_OUTSIDE");

            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrWebRequest>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("HR_WEB_REQUEST");

            entity.Property(e => e.Seq)
                .ValueGeneratedNever()
                .HasColumnName("seq");
            entity.Property(e => e.Approve1stDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_1st_date");
            entity.Property(e => e.Approve1stUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approve_1st_user");
            entity.Property(e => e.Approve1stYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("approve_1st_yn");
            entity.Property(e => e.Approve2ndDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_2nd_date");
            entity.Property(e => e.Approve2ndUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approve_2nd_user");
            entity.Property(e => e.Approve2ndYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("approve_2nd_yn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DaysCnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("days_cnt");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.HoursCnt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("hours_cnt");
            entity.Property(e => e.MhrsUpdateUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mhrs_update_user");
            entity.Property(e => e.MhrsUpdateYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("mhrs_update_yn");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.PeriodFrom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("period_from");
            entity.Property(e => e.PeriodTo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("period_to");
            entity.Property(e => e.RejectDate)
                .HasColumnType("datetime")
                .HasColumnName("reject_date");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reject_reason");
            entity.Property(e => e.RejectUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reject_user");
            entity.Property(e => e.ReqContent)
                .HasColumnType("text")
                .HasColumnName("req_content");
            entity.Property(e => e.ReqDate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("req_date");
            entity.Property(e => e.ReqIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("req_ip");
            entity.Property(e => e.ReqSubType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("req_sub_type");
            entity.Property(e => e.ReqTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("req_title");
            entity.Property(e => e.ReqType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("req_type");
            entity.Property(e => e.SickdayYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("sickday_yn");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<HrWebUser>(entity =>
        {
            entity.HasKey(e => e.EmplCode);

            entity.ToTable("HR_WEB_USER");

            entity.HasIndex(e => e.Email, "IX_HR_WEB_USER_1").IsUnique();

            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.LastLoginDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("last_login_date");
            entity.Property(e => e.LoginCnt)
                .HasDefaultValueSql("((1))")
                .HasColumnName("login_cnt");
            entity.Property(e => e.MmsLevel)
                .HasDefaultValueSql("((1))")
                .HasColumnName("mms_level");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.NickName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nick_name");
            entity.Property(e => e.Pw)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pw");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Temp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("temp");
        });

        modelBuilder.Entity<IfMpsDetail>(entity =>
        {
            entity.HasKey(e => e.MpsDetailSid).HasName("PK__IF_MPS_D__02EF3B8A108B795B");

            entity.ToTable("IF_MPS_DETAIL");

            entity.HasIndex(e => e.MpsMasterSid, "XIF1IF_MPS_DETAIL");

            entity.Property(e => e.MpsDetailSid)
                .ValueGeneratedNever()
                .HasColumnName("mps_detail_sid");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsColorActual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_color_actual");
            entity.Property(e => e.MpsColorId).HasColumnName("mps_color_id");
            entity.Property(e => e.MpsColorIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_color_ip");
            entity.Property(e => e.MpsCustPono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_cust_pono");
            entity.Property(e => e.MpsGraphicStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_graphic_style");
            entity.Property(e => e.MpsGraphicStyleId).HasColumnName("mps_graphic_style_id");
            entity.Property(e => e.MpsIndcDate)
                .HasColumnType("datetime")
                .HasColumnName("mps_indc_date");
            entity.Property(e => e.MpsMasterId).HasColumnName("mps_master_id");
            entity.Property(e => e.MpsMasterSid).HasColumnName("mps_master_sid");
            entity.Property(e => e.MpsOrderQty).HasColumnName("mps_order_qty");
            entity.Property(e => e.MpsStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_style");
            entity.Property(e => e.MpsStyleDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mps_style_desc");
            entity.Property(e => e.MpsStyleId).HasColumnName("mps_style_id");
            entity.Property(e => e.MpsWoId).HasColumnName("mps_wo_id");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<IfMpsEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__IF_MPS_E__2370F727164452B1");

            entity.ToTable("IF_MPS_EVENT");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("event_id");
            entity.Property(e => e.ConfirmDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.CustCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cust_code");
            entity.Property(e => e.EventDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("event_date");
            entity.Property(e => e.EventDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("event_desc");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.VendCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vend_code");
        });

        modelBuilder.Entity<IfMpsMaster>(entity =>
        {
            entity.HasKey(e => e.MpsMasterSid).HasName("PK__IF_MPS_M__696BDA0B1BFD2C07");

            entity.ToTable("IF_MPS_MASTER");

            entity.HasIndex(e => new { e.CustCode, e.OrgCode }, "XIF1IF_MPS_MASTER");

            entity.HasIndex(e => new { e.VendCode, e.OrgCode }, "XIF2IF_MPS_MASTER");

            entity.Property(e => e.MpsMasterSid)
                .ValueGeneratedNever()
                .HasColumnName("mps_master_sid");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CustCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cust_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsContact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_contact");
            entity.Property(e => e.MpsMasterId).HasColumnName("mps_master_id");
            entity.Property(e => e.MpsSeason)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_season");
            entity.Property(e => e.MpsSeasonyear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mps_seasonyear");
            entity.Property(e => e.MpsTotalOrderQty).HasColumnName("mps_total_order_qty");
            entity.Property(e => e.MpsWono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_wono");
            entity.Property(e => e.MpsYardPcs)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("mps_yard_pcs");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VendCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vend_code");
        });

        modelBuilder.Entity<IfMpsStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IF_MPS_STAGE");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsColorActual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_color_actual");
            entity.Property(e => e.MpsColorId).HasColumnName("mps_color_id");
            entity.Property(e => e.MpsColorIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_color_ip");
            entity.Property(e => e.MpsContact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_contact");
            entity.Property(e => e.MpsCustId).HasColumnName("mps_cust_id");
            entity.Property(e => e.MpsCustPono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_cust_pono");
            entity.Property(e => e.MpsDueDate)
                .HasColumnType("datetime")
                .HasColumnName("mps_due_date");
            entity.Property(e => e.MpsGraphicStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_graphic_style");
            entity.Property(e => e.MpsGraphicStyleId).HasColumnName("mps_graphic_style_id");
            entity.Property(e => e.MpsIndcDate)
                .HasColumnType("datetime")
                .HasColumnName("mps_indc_date");
            entity.Property(e => e.MpsMasterId).HasColumnName("mps_master_id");
            entity.Property(e => e.MpsOrderQty).HasColumnName("mps_order_qty");
            entity.Property(e => e.MpsSeason)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_season");
            entity.Property(e => e.MpsSeasonYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mps_season_year");
            entity.Property(e => e.MpsShipOutDate)
                .HasColumnType("datetime")
                .HasColumnName("mps_ship_out_date");
            entity.Property(e => e.MpsStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_style");
            entity.Property(e => e.MpsStyleDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mps_style_desc");
            entity.Property(e => e.MpsStyleId).HasColumnName("mps_style_id");
            entity.Property(e => e.MpsVendId).HasColumnName("mps_vend_id");
            entity.Property(e => e.MpsWoId).HasColumnName("mps_wo_id");
            entity.Property(e => e.MpsWono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_wono");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<IfMpsStyle>(entity =>
        {
            entity.HasKey(e => e.MpsStyleId).HasName("PK__IF_MPS_S__A812576224927208");

            entity.ToTable("IF_MPS_STYLE");

            entity.Property(e => e.MpsStyleId)
                .ValueGeneratedNever()
                .HasColumnName("mps_style_id");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_style");
            entity.Property(e => e.MpsStyleDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mps_style_desc");
            entity.Property(e => e.MpsStyleImage)
                .HasColumnType("image")
                .HasColumnName("mps_style_image");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<IfProcess>(entity =>
        {
            entity.HasKey(e => e.ProcessSid).HasName("PK__IF_PROCE__442C2E022A4B4B5E");

            entity.ToTable("IF_PROCESS");

            entity.HasIndex(e => e.ProcessLibSid, "XIF1IF_PROCESS");

            entity.HasIndex(e => e.MpsMasterSid, "XIF4IF_PROCESS");

            entity.HasIndex(e => e.UserCode, "XIF5IF_PROCESS");

            entity.Property(e => e.ProcessSid)
                .ValueGeneratedNever()
                .HasColumnName("process_sid");
            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.ConfirmUserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("confirm_user_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Date2)
                .HasColumnType("datetime")
                .HasColumnName("date2");
            entity.Property(e => e.LocalModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("local_modified_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsMasterSid).HasColumnName("mps_master_sid");
            entity.Property(e => e.ProcessLibSid).HasColumnName("process_lib_sid");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TargetLength)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("target_length");
            entity.Property(e => e.TargetQty).HasColumnName("target_qty");
            entity.Property(e => e.UserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_code");
        });

        modelBuilder.Entity<IfProcessLibrary>(entity =>
        {
            entity.HasKey(e => e.ProcessLibSid).HasName("PK__IF_PROCE__2EB6FD18300424B4");

            entity.ToTable("IF_PROCESS_LIBRARY");

            entity.HasIndex(e => e.OrgCode, "XIF1IF_PROCESS_LIBRARY");

            entity.HasIndex(e => new { e.VendCode, e.OrgCode }, "XIF2IF_PROCESS_LIBRARY");

            entity.Property(e => e.ProcessLibSid)
                .ValueGeneratedNever()
                .HasColumnName("process_lib_sid");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Date1Check).HasColumnName("date1_check");
            entity.Property(e => e.Date1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("date1_name");
            entity.Property(e => e.Date2Check).HasColumnName("date2_check");
            entity.Property(e => e.Date2Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("date2_name");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Percentage1Check).HasColumnName("percentage1_check");
            entity.Property(e => e.Percentage1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("percentage1_name");
            entity.Property(e => e.ProcessCheck).HasColumnName("process_check");
            entity.Property(e => e.ProcessName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("process_name");
            entity.Property(e => e.ProcessUnit).HasColumnName("process_unit");
            entity.Property(e => e.Qty1Check).HasColumnName("qty1_check");
            entity.Property(e => e.Qty1UnitName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("qty1_unit_name");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.String1Check).HasColumnName("string1_check");
            entity.Property(e => e.String1Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("string1_name");
            entity.Property(e => e.VendCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vend_code");
        });

        modelBuilder.Entity<IfProgress>(entity =>
        {
            entity.HasKey(e => e.ProgressSid).HasName("PK__IF_PROGR__9378576A35BCFE0A");

            entity.ToTable("IF_PROGRESS");

            entity.HasIndex(e => e.ProcessSid, "XIF1IF_PROGRESS");

            entity.HasIndex(e => e.UserCode, "XIF2IF_PROGRESS");

            entity.Property(e => e.ProgressSid)
                .ValueGeneratedNever()
                .HasColumnName("progress_sid");
            entity.Property(e => e.BaseDate)
                .HasColumnType("datetime")
                .HasColumnName("base_date");
            entity.Property(e => e.ConfirmComment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("confirm_comment");
            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.ConfirmUserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("confirm_user_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.LocalModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("local_modified_date");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsColorId).HasColumnName("mps_color_id");
            entity.Property(e => e.MpsColorIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_color_ip");
            entity.Property(e => e.MpsCustPono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_cust_pono");
            entity.Property(e => e.MpsGraphicStyleId).HasColumnName("mps_graphic_style_id");
            entity.Property(e => e.MpsIndcDate)
                .HasColumnType("datetime")
                .HasColumnName("mps_indc_date");
            entity.Property(e => e.MpsStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_style");
            entity.Property(e => e.MpsStyleId).HasColumnName("mps_style_id");
            entity.Property(e => e.Percentage1)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("percentage1");
            entity.Property(e => e.ProcessSid).HasColumnName("process_sid");
            entity.Property(e => e.Qty1)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("qty1");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.String1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("string1");
            entity.Property(e => e.UserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_code");
        });

        modelBuilder.Entity<TaCodeMapping>(entity =>
        {
            entity.HasKey(e => new { e.Class, e.OldCode });

            entity.ToTable("TA_CODE_MAPPING");

            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.OldCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("old_code");
            entity.Property(e => e.NewCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("new_code");
        });

        modelBuilder.Entity<TaGeneralCode>(entity =>
        {
            entity.HasKey(e => new { e.Class, e.Code }).HasName("PK__TA_GENER__E288AC23681373AD");

            entity.ToTable("TA_GENERAL_CODE");

            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.Code)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.SortNo).HasColumnName("sort_no");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Value1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value_1");
            entity.Property(e => e.Value2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value_2");
            entity.Property(e => e.Value3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("value_3");
        });

        modelBuilder.Entity<TaPermission>(entity =>
        {
            entity.HasKey(e => new { e.SysCode, e.GroupCode, e.PgmCode }).HasName("PK__TA_PERMI__6F493C5844CA3770");

            entity.ToTable("TA_PERMISSION");

            entity.Property(e => e.SysCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sys_code");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.PgmCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pgm_code");
            entity.Property(e => e.ClearYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("clear_yn");
            entity.Property(e => e.CopyYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("copy_yn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DeleteYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("delete_yn");
            entity.Property(e => e.DetailYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("detail_yn");
            entity.Property(e => e.ExcelYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("excel_yn");
            entity.Property(e => e.HelpYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("help_yn");
            entity.Property(e => e.InquiryYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("inquiry_yn");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.NewYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("new_yn");
            entity.Property(e => e.OpenYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('Y')")
                .HasColumnName("open_yn");
            entity.Property(e => e.PrintYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("print_yn");
            entity.Property(e => e.SaveYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("save_yn");
            entity.Property(e => e.SearchYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("search_yn");
            entity.Property(e => e.UploadYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("upload_yn");
        });

        modelBuilder.Entity<TaProgram>(entity =>
        {
            entity.HasKey(e => new { e.SysCode, e.PgmCode }).HasName("PK__TA_PROGR__ACD370E056E8E7AB");

            entity.ToTable("TA_PROGRAM");

            entity.Property(e => e.SysCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sys_code");
            entity.Property(e => e.PgmCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pgm_code");
            entity.Property(e => e.ClearYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("clear_yn");
            entity.Property(e => e.CopyYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("copy_yn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.DeleteYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("delete_yn");
            entity.Property(e => e.DetailYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("detail_yn");
            entity.Property(e => e.ExcelYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("excel_yn");
            entity.Property(e => e.FormId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("form_id");
            entity.Property(e => e.HelpYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("help_yn");
            entity.Property(e => e.InquiryYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("inquiry_yn");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.NewYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("new_yn");
            entity.Property(e => e.PgmLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pgm_level");
            entity.Property(e => e.PgmModule)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pgm_module");
            entity.Property(e => e.PgmName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pgm_name");
            entity.Property(e => e.PgmType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pgm_type");
            entity.Property(e => e.PrintYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("print_yn");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.SaveYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("save_yn");
            entity.Property(e => e.SearchYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("search_yn");
            entity.Property(e => e.SortNo).HasColumnName("sort_no");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UploadYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("upload_yn");
            entity.Property(e => e.UpperPgmCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("upper_pgm_code");
        });

        modelBuilder.Entity<TaPwConfirmSentence>(entity =>
        {
            entity.HasKey(e => e.Type);

            entity.ToTable("TA_PW_CONFIRM_SENTENCE");

            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.ConfirmKey)
                .HasMaxLength(256)
                .HasColumnName("confirm_key");
            entity.Property(e => e.ConfirmSentence)
                .HasMaxLength(256)
                .HasColumnName("confirm_sentence");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
        });

        modelBuilder.Entity<TaUser>(entity =>
        {
            entity.HasKey(e => e.UserCode).HasName("PK__TA_USER__EDC4140E3C69FB99");

            entity.ToTable("TA_USER");

            entity.HasIndex(e => new { e.CustCode, e.OrgCode }, "XIF1TA_USER");

            entity.HasIndex(e => new { e.VendCode, e.OrgCode }, "XIF2TA_USER");

            entity.HasIndex(e => e.OrgCode, "XIF3TA_USER");

            entity.Property(e => e.UserCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.CustCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cust_code");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("empl_code");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
            entity.Property(e => e.MpsId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_id");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.OtherOrgCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("other_org_code");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PayrollOrgOnly)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("payroll_org_only");
            entity.Property(e => e.PriorityLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("priority_level");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
            entity.Property(e => e.VendCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vend_code");
        });

        modelBuilder.Entity<TaUserGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserCode, e.SysCode }).HasName("PK__TA_USER___0523AFDA22751F6C");

            entity.ToTable("TA_USER_GROUP");

            entity.Property(e => e.UserCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user_code");
            entity.Property(e => e.SysCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sys_code");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_user");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("group_code");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.ModifiedUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("modified_user");
        });

        modelBuilder.Entity<TaVersion>(entity =>
        {
            entity.HasKey(e => new { e.SysId, e.Source }).HasName("PK__TA_VERSI__8A08B5C14222D4EF");

            entity.ToTable("TA_VERSION");

            entity.Property(e => e.SysId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sys_id");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("source");
            entity.Property(e => e.DllYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("dll_yn");
            entity.Property(e => e.LocalPath)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("local_path");
            entity.Property(e => e.ServerPath)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("server_path");
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("version");
        });

        modelBuilder.Entity<TempInsSurf09162022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempInsSurf09162022");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.CovType).HasMaxLength(255);
            entity.Property(e => e.EmplCode)
                .HasMaxLength(255)
                .HasColumnName("empl_code");
            entity.Property(e => e.InsuredEmployee).HasMaxLength(255);
            entity.Property(e => e.MainName).HasMaxLength(255);
            entity.Property(e => e.RateCate).HasColumnName("rate_cate");
            entity.Property(e => e._6bnt)
                .HasColumnType("money")
                .HasColumnName("6BNT");
            entity.Property(e => e._6brt)
                .HasColumnType("money")
                .HasColumnName("6BRT");
            entity.Property(e => e._6buh)
                .HasColumnType("money")
                .HasColumnName("6BUH");
        });

        modelBuilder.Entity<TempInsSurf10112018>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempInsSurf10112018");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.CovType).HasMaxLength(255);
            entity.Property(e => e.EmplCode)
                .HasMaxLength(255)
                .HasColumnName("empl_code");
            entity.Property(e => e.InsuredEmployee).HasMaxLength(255);
            entity.Property(e => e.MainName).HasMaxLength(255);
            entity.Property(e => e.RateCate).HasColumnName("rate_cate");
            entity.Property(e => e._3009)
                .HasColumnType("money")
                .HasColumnName("3009");
            entity.Property(e => e._300d)
                .HasColumnType("money")
                .HasColumnName("300D");
            entity.Property(e => e._301d)
                .HasColumnType("money")
                .HasColumnName("301D");
            entity.Property(e => e._301r)
                .HasColumnType("money")
                .HasColumnName("301R");
            entity.Property(e => e._301v)
                .HasColumnType("money")
                .HasColumnName("301V");
            entity.Property(e => e._302g)
                .HasColumnType("money")
                .HasColumnName("302G");
            entity.Property(e => e._302q)
                .HasColumnType("money")
                .HasColumnName("302Q");
            entity.Property(e => e._303f)
                .HasColumnType("money")
                .HasColumnName("303F");
            entity.Property(e => e._304m)
                .HasColumnType("money")
                .HasColumnName("304M");
            entity.Property(e => e._304r)
                .HasColumnType("money")
                .HasColumnName("304R");
            entity.Property(e => e._304v)
                .HasColumnType("money")
                .HasColumnName("304V");
            entity.Property(e => e._304z)
                .HasColumnType("money")
                .HasColumnName("304Z");
            entity.Property(e => e._3057)
                .HasColumnType("money")
                .HasColumnName("3057");
        });

        modelBuilder.Entity<TempInsSurfFor2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempInsSurfFor2024");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.CovType).HasMaxLength(20);
            entity.Property(e => e.EmplCode)
                .HasMaxLength(20)
                .HasColumnName("empl_code");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuredEmployee).HasMaxLength(50);
            entity.Property(e => e.MainName).HasMaxLength(50);
            entity.Property(e => e.RateCate).HasColumnName("rate_cate");
            entity.Property(e => e._6rhb)
                .HasColumnType("money")
                .HasColumnName("6RHB");
            entity.Property(e => e._6rhz)
                .HasColumnType("money")
                .HasColumnName("6RHZ");
            entity.Property(e => e._8nag)
                .HasColumnType("money")
                .HasColumnName("8NAG");
        });

        modelBuilder.Entity<TempInsurancePlan2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempInsurancePlan2024");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e._6rhb)
                .HasColumnType("money")
                .HasColumnName("6RHB");
            entity.Property(e => e._6rhz)
                .HasColumnType("money")
                .HasColumnName("6RHZ");
            entity.Property(e => e._8nag)
                .HasColumnType("money")
                .HasColumnName("8NAG");
        });

        modelBuilder.Entity<TempInsurePlan2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempInsurePlan2023");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e._6bnt)
                .HasColumnType("money")
                .HasColumnName("6BNT");
            entity.Property(e => e._6brt)
                .HasColumnType("money")
                .HasColumnName("6BRT");
            entity.Property(e => e._6buh)
                .HasColumnType("money")
                .HasColumnName("6BUH");
        });

        modelBuilder.Entity<VEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_EMPLOYEE");

            entity.Property(e => e.ActiveYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("active_yn");
            entity.Property(e => e.ComEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("com_email");
            entity.Property(e => e.ComTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("com_tel");
            entity.Property(e => e.ComTelExt)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("com_tel_ext");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.DeptName2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dept_name_2");
            entity.Property(e => e.DivName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("div_name");
            entity.Property(e => e.EmplCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_code");
            entity.Property(e => e.EmplName)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("empl_name");
            entity.Property(e => e.EmplType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empl_type");
            entity.Property(e => e.Org)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org");
        });

        modelBuilder.Entity<VwOpIfProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_OP_IF_Process");

            entity.Property(e => e.ConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("confirm_date");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Date2)
                .HasColumnType("datetime")
                .HasColumnName("date2");
            entity.Property(e => e.LocalModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("local_modified_date");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsMasterId).HasColumnName("mps_master_id");
            entity.Property(e => e.MpsMasterSid).HasColumnName("mps_master_sid");
            entity.Property(e => e.ProcessLibSid).HasColumnName("process_lib_sid");
            entity.Property(e => e.ProcessName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("process_name");
            entity.Property(e => e.ProcessSid).HasColumnName("process_sid");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TargetLength)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("target_length");
            entity.Property(e => e.TargetQty).HasColumnName("target_qty");
            entity.Property(e => e.UserCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_code");
        });

        modelBuilder.Entity<VwOpMpsmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_OP_MPSMaster");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.CustCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cust_code");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modified_date");
            entity.Property(e => e.MpsContact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_contact");
            entity.Property(e => e.MpsMasterId).HasColumnName("mps_master_id");
            entity.Property(e => e.MpsMasterSid).HasColumnName("mps_master_sid");
            entity.Property(e => e.MpsSeason)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_season");
            entity.Property(e => e.MpsSeasonyear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mps_seasonyear");
            entity.Property(e => e.MpsStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_style");
            entity.Property(e => e.MpsStyleDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mps_style_desc");
            entity.Property(e => e.MpsStyleId).HasColumnName("mps_style_id");
            entity.Property(e => e.MpsTotalOrderQty).HasColumnName("mps_total_order_qty");
            entity.Property(e => e.MpsWono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mps_wono");
            entity.Property(e => e.MpsYardPcs)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("mps_yard_pcs");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("org_code");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VendCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vend_code");
        });

        modelBuilder.Entity<XxLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XX_Label");

            entity.Property(e => e.Class)
                .HasMaxLength(255)
                .HasColumnName("class");
            entity.Property(e => e.ClassSn).HasColumnName("class_sn");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .HasColumnName("company");
            entity.Property(e => e.Dept)
                .HasMaxLength(255)
                .HasColumnName("dept");
            entity.Property(e => e.EmplCode).HasColumnName("empl_code");
            entity.Property(e => e.EmplName)
                .HasMaxLength(255)
                .HasColumnName("empl_name");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(255)
                .HasColumnName("manufacturer");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .HasColumnName("model");
            entity.Property(e => e.OtherName)
                .HasMaxLength(255)
                .HasColumnName("other_name");
            entity.Property(e => e.ProductSn)
                .HasMaxLength(255)
                .HasColumnName("product_sn");
            entity.Property(e => e.PropertyName)
                .HasMaxLength(255)
                .HasColumnName("property_name");
            entity.Property(e => e.PropertyType)
                .HasMaxLength(255)
                .HasColumnName("property_type");
            entity.Property(e => e.Purpose)
                .HasMaxLength(255)
                .HasColumnName("purpose");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasColumnName("remark");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Specification)
                .HasMaxLength(255)
                .HasColumnName("specification");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("update_date");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<DayTimeOffApprovalHistoryDTO>(entity => { entity.HasNoKey(); });

        modelBuilder.Entity<DayTimeOffRequestResultDTO>(entity => { entity.HasNoKey(); });

        modelBuilder.Entity<EmployeeDayTimeOffHistoryDTO>(entity => { entity.HasNoKey(); });

        modelBuilder.Entity<EmployeeDayTimeOffRemainingDTO>(entity => { entity.HasNoKey(); });

        modelBuilder.Entity<PendingDayTimeOffApprovalDTO>(entity => { entity.HasNoKey(); });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
