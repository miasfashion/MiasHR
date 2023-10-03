using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiasHR.Api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) 
        {/*
            migrationBuilder.CreateTable(
                name: "GB_CUSTOMER",
                columns: table => new
                {
                    cust_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cust_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    mps_cust_id = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    user_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_CUSTO__B40DCE487F60ED59", x => new { x.cust_code, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "GB_DEPARTMENT",
                columns: table => new
                {
                    dept_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    dept_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    div_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sort_no = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    admin_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    manage_empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dept_level = table.Column<int>(type: "int", nullable: true),
                    upper_dept_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    store_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    qb_key = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_DEPAR__BF178631339FAB6E", x => new { x.dept_code, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "GB_DIVISION",
                columns: table => new
                {
                    div_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    div_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    sort_no = table.Column<int>(type: "int", nullable: true),
                    tree_sort_no = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    admin_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    div_level = table.Column<int>(type: "int", nullable: true),
                    upper_div_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_DIVIS__BDE6D4CD395884C4", x => new { x.div_code, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "GB_ORGANIZATION",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    short_name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    seq = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    org_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    street = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    zip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    country = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fax = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    homepage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    temp_org_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_ORGAN__68B12E5D3F115E1A", x => x.org_code);
                });

            migrationBuilder.CreateTable(
                name: "GB_ORGANIZATION_NUMBER",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @class = table.Column<string>(name: "class", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    no = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    start_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    expire_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    notice_send_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_ORGAN__956CD596282DF8C2", x => new { x.org_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "GB_TASK",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    task_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    task_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    start_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    end_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_TASK__0C5C0748693CA210", x => new { x.org_code, x.task_code });
                });

            migrationBuilder.CreateTable(
                name: "GB_TASK_MEMBER",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    task_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_TASK___128E2A0A6383C8BA", x => new { x.org_code, x.task_code, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "GB_VENDOR",
                columns: table => new
                {
                    vend_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    vend_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    mps_vend_id = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    user_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GB_VENDO__40C771430AD2A005", x => new { x.vend_code, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_ASSIGNED_PROPERTY",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    other_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    @class = table.Column<string>(name: "class", type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    class_sn = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    property_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    manufacturer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    model = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    specification = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    product_sn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    purpose = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_ASSIGNED_PROPERTY", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_AUTO_ACCIDENT",
                columns: table => new
                {
                    manage_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    report_date = table.Column<string>(type: "char(18)", unicode: false, fixedLength: true, maxLength: 18, nullable: true),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    dept_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    report_empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    auto_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    auto_purpose = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    ampm = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    time = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    accident_place = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    accident_desc = table.Column<string>(type: "text", nullable: true),
                    other_model = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    other_plate_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    other_vin_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    other_name = table.Column<string>(type: "char(18)", unicode: false, fixedLength: true, maxLength: 18, nullable: true),
                    other_license_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    other_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    other_auto_desc = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_AUTO_ACCIDENT", x => x.manage_no);
                });

            migrationBuilder.CreateTable(
                name: "HR_CONTACT",
                columns: table => new
                {
                    other_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    other_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    street = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    zip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tel2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cell = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fax = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_OTHER__0E0B69A07A672E12", x => x.other_code);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE",
                columns: table => new
                {
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    active_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    first_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    middle_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    last_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nick_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    div_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dept_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    upper_empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    com_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    com_tel_ext = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    com_fax = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    com_email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position_yrs = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    building_loc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    hire_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    pto_hire_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    resign_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    resign_reason = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tna_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    badge_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    payroll_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    payroll_org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    hourlybase_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    photo = table.Column<byte[]>(type: "image", nullable: true),
                    photo_thumbnail = table.Column<byte[]>(type: "image", nullable: true),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    business_title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    other = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    qb_key = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    qb_send_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__14A650FA2DE6D218", x => x.empl_code);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_ALL_HISTORY",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    active_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    empl_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    first_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    middle_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    last_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nick_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    div_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dept_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    com_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    com_tel_ext = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    com_fax = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    com_email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position_yrs = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    building_loc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    hire_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    resign_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    tna_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    badge_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    payroll_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    payroll_org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    hourlybase_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    photo = table.Column<byte[]>(type: "image", nullable: true),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    business_title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    gender = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    birth_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    degree = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    married_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    street = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    zip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    country = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    street2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    city2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    zip2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    country2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cell = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    resident_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alien_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    i9_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    ssn = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    w4_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    exemptions = table.Column<int>(type: "int", nullable: true),
                    memo = table.Column<string>(type: "text", nullable: true),
                    contact1_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact1_relationship = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact1_addr1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact1_addr2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact1_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact1_cell = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact2_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact2_relationship = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact2_addr1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact2_addr2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact2_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact2_cell = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    pto_hire_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    resign_reason = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLOYEE_ALL_HISTORY", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_APPROVER",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    approver_1st = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    approver_2nd = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    other_manager = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    pto_notice_manager = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMPLOYEE_APPROVER", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_CAREER",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    company_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    job_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    leave_reason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    from_yyyymm = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    to_yyyymm = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    salary = table.Column<decimal>(type: "numeric(12,3)", nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__3A4E25C017036CC0", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_DETAIL",
                columns: table => new
                {
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    active_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    gender = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    birth_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    degree = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    married_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    street = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    zip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    country = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    street2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    city2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    zip2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    country2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cell = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    resident_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alien_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    i9_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    ssn = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    w4_status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    exemptions = table.Column<int>(type: "int", nullable: true),
                    memo = table.Column<string>(type: "text", nullable: true),
                    contact1_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact1_relationship = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact1_addr1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact1_addr2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact1_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact1_cell = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact2_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact2_relationship = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact2_addr1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact2_addr2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact2_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    contact2_cell = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    other = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__14A650FA1CBC4616", x => x.empl_code);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_EDUCATION",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    edu_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    edu_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    edu_content = table.Column<string>(type: "text", nullable: true),
                    from_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    to_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    finish_degree = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__3A4E25C000200768", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_HISTORY",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    hist_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    old_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    old_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    new_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    new_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__3A4E25C005D8E0BE", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_PLAN",
                columns: table => new
                {
                    yyyymm = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    dept_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    plan_cnt = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__66CEDDAE04AFB25B", x => new { x.yyyymm, x.dept_code, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_RP",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    rp_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    rp_title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__3A4E25C00B91BA14", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_SCANIMAGE",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    image = table.Column<byte[]>(type: "image", nullable: true),
                    image_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__3A4E25C01E05700A", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_EMPLOYEE_SKILL",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    skill = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    certificate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_EMPLO__3A4E25C06EF57B66", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_BASIC",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('a')"),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    category = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    eval_per = table.Column<short>(type: "smallint", nullable: true),
                    point_from = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    point_to = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    distribute_per = table.Column<short>(type: "smallint", nullable: true),
                    p_from = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    p_to = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_BASIC", x => new { x.year, x.term, x.category, x.grade, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_EMPLOYEE_RESULT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    factor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    s1_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    s1_factor_point = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    s2_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    s2_factor_point = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    s3_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    s3_factor_point = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_EMPLOYEE_RESULT", x => new { x.org_code, x.year, x.term, x.empl_code, x.factor });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_EMPLOYEE_SUMMARY",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position_yrs = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    s1_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))"),
                    s2_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))"),
                    s3_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))"),
                    s4_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))"),
                    s5_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))"),
                    total_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))"),
                    s1_eval_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    s2_eval_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    s3_eval_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    eval_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    s1_comment = table.Column<string>(type: "text", nullable: true),
                    s2_comment = table.Column<string>(type: "text", nullable: true),
                    s5_comment = table.Column<string>(type: "text", nullable: true),
                    s1_factor_point = table.Column<short>(type: "smallint", nullable: true),
                    s2_factor_point = table.Column<short>(type: "smallint", nullable: true),
                    s3_factor_point = table.Column<short>(type: "smallint", nullable: true),
                    late_cnt = table.Column<short>(type: "smallint", nullable: true),
                    warning_cnt = table.Column<short>(type: "smallint", nullable: true),
                    warning_minutes = table.Column<short>(type: "smallint", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    grp_eval_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_SUMMARY", x => new { x.org_code, x.year, x.term, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_FACTOR",
                columns: table => new
                {
                    factor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    factor_desc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<short>(type: "smallint", nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_FACTOR", x => x.factor);
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_FACTOR_DETAIL",
                columns: table => new
                {
                    factor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    factor_grade = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    point = table.Column<short>(type: "smallint", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_FACTOR_DETAIL", x => new { x.factor, x.factor_grade });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_FACTOR_MAPPING",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    factor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_FACTOR_MAPPING", x => new { x.year, x.term, x.org_code, x.group_code, x.factor });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_GROUP",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    group_desc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    group_sort_no = table.Column<short>(type: "smallint", nullable: true),
                    div = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    div_sort_no = table.Column<short>(type: "smallint", nullable: true),
                    step1_appraiser = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    step2_appraiser = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    step3_appraiser = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_GROUP", x => new { x.org_code, x.year, x.term, x.group_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_GROUP_DEPT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    dept_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    dept_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dept_sort_no = table.Column<short>(type: "smallint", nullable: true),
                    div_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_GROUP_DEPT", x => new { x.org_code, x.year, x.term, x.dept_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_GROUP_RESULT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_GROUP_RESULT", x => new { x.org_code, x.year, x.term, x.group_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_HALF_RESULT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position_yrs = table.Column<short>(type: "smallint", nullable: true),
                    b_payroll_monthly = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    b_oth1_monthly = table.Column<decimal>(type: "money", nullable: true),
                    b_oth2_monthly = table.Column<decimal>(type: "money", nullable: true),
                    b_oth3_monthly = table.Column<decimal>(type: "money", nullable: true),
                    avg_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    group_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    group_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    empl_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    empl_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    result_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    adj_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    bonus = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    oth1 = table.Column<decimal>(type: "money", nullable: true),
                    oth2 = table.Column<decimal>(type: "money", nullable: true),
                    oth3 = table.Column<decimal>(type: "money", nullable: true),
                    bonus_total = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    bonus_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_HALF_RESULT", x => new { x.org_code, x.year, x.term, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_HALF_RESULT_LOG",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    log_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_user_id = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position_yrs = table.Column<short>(type: "smallint", nullable: true),
                    b_payroll_monthly = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    b_oth1_monthly = table.Column<decimal>(type: "money", nullable: true),
                    b_oth2_monthly = table.Column<decimal>(type: "money", nullable: true),
                    b_oth3_monthly = table.Column<decimal>(type: "money", nullable: true),
                    avg_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    group_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    group_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    empl_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    empl_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    result_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    adj_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    bonus = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    oth1 = table.Column<decimal>(type: "money", nullable: true),
                    oth2 = table.Column<decimal>(type: "money", nullable: true),
                    oth3 = table.Column<decimal>(type: "money", nullable: true),
                    bonus_total = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    bonus_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_HALF_RESULT_LOG", x => new { x.seq, x.org_code, x.year, x.term, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_MANAGER",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    mgr_group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_MANAGER", x => new { x.org_code, x.year, x.term, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_PROMOTION_EMPLOYEE",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    old_position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    new_position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_PROMOTION_EMPLOYEE", x => new { x.org_code, x.year, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_SELF_RESULT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    factor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    self_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    self_factor_point = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_SELF_RESULT", x => new { x.org_code, x.year, x.term, x.empl_code, x.factor });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_SELF_SUMMARY",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    self_point = table.Column<decimal>(type: "decimal(7,2)", nullable: true, defaultValueSql: "((0))"),
                    self_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    self_comment = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_SELF_SUMMARY", x => new { x.org_code, x.year, x.term, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_YEAR_RESULT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position_yrs = table.Column<short>(type: "smallint", nullable: true),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    b_payroll_annual = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    b_oth1_annual = table.Column<decimal>(type: "money", nullable: true),
                    b_oth2_annual = table.Column<decimal>(type: "money", nullable: true),
                    b_oth3_annual = table.Column<decimal>(type: "money", nullable: true),
                    avg_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    t1_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    t1_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    t2_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    t2_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    result_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    adj_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    promo_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    payroll_increase = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    oth1_increase = table.Column<decimal>(type: "money", nullable: true),
                    oth2_increase = table.Column<decimal>(type: "money", nullable: true),
                    oth3_increase = table.Column<decimal>(type: "money", nullable: true),
                    increase_total = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    increase_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    a_payroll_annual = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    a_oth1_annual = table.Column<decimal>(type: "money", nullable: true),
                    a_oth2_annual = table.Column<decimal>(type: "money", nullable: true),
                    a_oth3_annual = table.Column<decimal>(type: "money", nullable: true),
                    oth1_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth1_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    oth2_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth2_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    oth3_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth3_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_YEAR_RESULT", x => new { x.org_code, x.year, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_EVAL_YEAR_RESULT_LOG",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    log_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_user_id = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    position_yrs = table.Column<short>(type: "smallint", nullable: true),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    b_payroll_annual = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    b_oth1_annual = table.Column<decimal>(type: "money", nullable: true),
                    b_oth2_annual = table.Column<decimal>(type: "money", nullable: true),
                    b_oth3_annual = table.Column<decimal>(type: "money", nullable: true),
                    avg_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    t1_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    t1_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    t2_grade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    t2_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    result_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    adj_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    promo_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    payroll_increase = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    oth1_increase = table.Column<decimal>(type: "money", nullable: true),
                    oth2_increase = table.Column<decimal>(type: "money", nullable: true),
                    oth3_increase = table.Column<decimal>(type: "money", nullable: true),
                    increase_total = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    increase_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    a_payroll_annual = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    a_oth1_annual = table.Column<decimal>(type: "money", nullable: true),
                    a_oth2_annual = table.Column<decimal>(type: "money", nullable: true),
                    a_oth3_annual = table.Column<decimal>(type: "money", nullable: true),
                    oth1_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth1_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    oth2_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth2_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    oth3_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth3_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EVAL_YEAR_RESULT_LOG", x => new { x.seq, x.org_code, x.year, x.empl_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_GENERAL_CODE",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    @class = table.Column<string>(name: "class", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    code = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    sort_no = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    value_1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    value_2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    value_3 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    value_4 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    number_1 = table.Column<int>(type: "int", nullable: true),
                    number_2 = table.Column<int>(type: "int", nullable: true),
                    decimal_1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    remark = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    day_hours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_GENER__4699A49F6DCC4D03", x => new { x.org_code, x.@class, x.code });
                });

            migrationBuilder.CreateTable(
                name: "HR_HOLIDAY",
                columns: table => new
                {
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_HOLID__D9DE21FC74AE54BC", x => x.date);
                });

            migrationBuilder.CreateTable(
                name: "HR_INCIDENT",
                columns: table => new
                {
                    manage_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    ampm = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    time = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    person_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    last_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    first_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    street = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    state = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    zip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    home_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    work_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    other_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    gender = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    accident_place = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    witness1_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    witness1_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    witness2_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    witness2_tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    call_911_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    first_aid_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    hospital_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    doctor_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    hospital_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    workcomp_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    workcomp_desc = table.Column<string>(type: "text", nullable: true),
                    reported_by = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    reported_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    reviewed_by = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    reviewed_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    injured_x = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    injured_y = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    incident_desc = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_INCIDENT", x => x.manage_no);
                });

            migrationBuilder.CreateTable(
                name: "HR_INS_EMPL_PICKED",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ins_picked_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    surfing_id = table.Column<int>(type: "int", nullable: true),
                    plan_id = table.Column<int>(type: "int", nullable: true),
                    coverage = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ee_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    dep_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    total_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    ee_pay_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    company_pay_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    bundle_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_INS_EMPL_PICKED", x => new { x.ins_picked_id, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_INS_EMPL_SURFING",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    surfing_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true),
                    plan_id = table.Column<int>(type: "int", nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    coverage = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ee_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    dep_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    total_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_ee_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_eesp_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_eech_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_fam_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_ee_bundle_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_eesp_bundle_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_eech_bundle_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    other_fam_bundle_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_INS_EMPL_SURFING", x => new { x.surfing_id, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_INS_NOT_ENROLL",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    plan_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_INS_NOT_ENROLL", x => new { x.org_code, x.start_date, x.empl_code, x.plan_type });
                });

            migrationBuilder.CreateTable(
                name: "HR_INS_PLAN",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    plan_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true),
                    start_date = table.Column<DateTime>(type: "date", nullable: true),
                    plan_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    plan_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    contract_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sort_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    plan_desc = table.Column<string>(type: "text", nullable: true),
                    plan_image = table.Column<byte[]>(type: "image", nullable: true),
                    open_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    pay_rate_for_ee = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "((0))"),
                    pay_rate_for_dep = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "((0))"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_INS_PLAN", x => new { x.plan_id, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_LOCKER",
                columns: table => new
                {
                    locker_group = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    reserve_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_LOCKER", x => new { x.locker_group, x.code });
                });

            migrationBuilder.CreateTable(
                name: "HR_PARKING_LOT",
                columns: table => new
                {
                    lot_group = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    lot_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    reserve_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    lot_image = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_PARKING_LOT", x => new { x.lot_group, x.lot_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_PAYROLL",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: true),
                    payroll_start_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    payroll_annual = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    payroll_monthly = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    payroll_semimonthly = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    payroll_biweekly = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    payroll_hourly = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    payroll_increase_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    oth1_payroll_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth1_payroll_monthly = table.Column<decimal>(type: "money", nullable: true),
                    oth1_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    oth1_increase_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    oth2_payroll_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth2_payroll_monthly = table.Column<decimal>(type: "money", nullable: true),
                    oth2_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    oth2_increase_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    oth3_payroll_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    oth3_payroll_monthly = table.Column<decimal>(type: "money", nullable: true),
                    oth3_start_month = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    oth3_increase_per = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_PAYROLL", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_PAYROLL_BENEFIT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: true),
                    pay_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cont_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    benefit1 = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    benefit2 = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    benefit3 = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    benefit4 = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    benefit5 = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    benefit_amt = table.Column<decimal>(type: "money", nullable: true),
                    adjust_amt = table.Column<decimal>(type: "money", nullable: true),
                    total_amt = table.Column<decimal>(type: "money", nullable: true, defaultValueSql: "((0))"),
                    id = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    yyyymm = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    remark2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_PAYROLL_BENEFIT", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_PAYROLL_BONUS",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: true),
                    pay_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    year = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    term = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    bonus = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_PAYROLL_BONUS", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_POLICY",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    content = table.Column<string>(type: "text", nullable: true),
                    consent_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    consent_content = table.Column<string>(type: "text", nullable: true),
                    sort_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    hit = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_POLICY", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_POLICY_CONSENT_LOG",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false),
                    policy_seq = table.Column<int>(type: "int", nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    consent_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_Policy_Consent_Log", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_PTO_FOR_INET",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    empl_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    day_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    day_type_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    start_date = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    end_date = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    crt_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HR_TNA_BADGE",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_code = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    person_id = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    person_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    card_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    inout = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    time = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    company_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    depart_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_TNA_BADGE", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_TNA_DAY",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    day_type = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    start_time = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    uto_applied_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('')"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_TNA_D__3A4E25C073852659", x => new { x.org_code, x.empl_code, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_TNA_EMAIL_NOTICE",
                columns: table => new
                {
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    type_desc = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    send_date = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    send_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    crt_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_TNA_EMAIL_NOTICE", x => new { x.empl_code, x.date });
                });

            migrationBuilder.CreateTable(
                name: "HR_TNA_INOUT",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    out_time = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    in_time = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    auto_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    auto_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    gas_card_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    gas_card_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    gas_card_amt = table.Column<decimal>(type: "money", nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_TNA_I__3A4E25C07EF6D905", x => new { x.org_code, x.date, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_TNA_START_TIME",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    start_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    end_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, defaultValueSql: "((99991231))"),
                    work_start_time = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    late_time = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    mon = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('Y')"),
                    tue = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('Y')"),
                    wed = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('Y')"),
                    thu = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('Y')"),
                    fri = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('Y')"),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_TNA_START_TIME", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_TNA_TIME",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    inout = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('IN')"),
                    update_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    update_reason = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    work_start_time = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    work_end_time = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    late_level = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    badge_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    badge_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    group_code = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HR_TRANSACTION",
                columns: table => new
                {
                    trans_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    code_len = table.Column<int>(type: "int", nullable: true),
                    last_no = table.Column<int>(type: "int", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_TRANS__B4E867FA5DCAEF64", x => new { x.trans_type, x.org_code });
                });

            migrationBuilder.CreateTable(
                name: "HR_VACATION",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    yyyy = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    v_type = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    days = table.Column<decimal>(type: "decimal(6,2)", nullable: true, defaultValueSql: "((0))"),
                    preMonthLeftDays = table.Column<decimal>(type: "decimal(6,2)", nullable: true, defaultValueSql: "((0.0))"),
                    monthUsedDays = table.Column<decimal>(type: "decimal(6,2)", nullable: true, defaultValueSql: "((0.0))"),
                    monthAdjDays = table.Column<decimal>(type: "decimal(6,2)", nullable: true, defaultValueSql: "((0.0))"),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_VACAT__AC8DCEA15165187F", x => new { x.org_code, x.empl_code, x.yyyy, x.v_type, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_VACATION_20150707",
                columns: table => new
                {
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    yyyy = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    v_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    days = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HR_VACAT__20150707_AC8DCEA15165187F", x => new { x.org_code, x.empl_code, x.yyyy, x.v_type, x.seq });
                });

            migrationBuilder.CreateTable(
                name: "HR_WEB_LOGIN_LOG",
                columns: table => new
                {
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    login_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    ip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    accept_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('Y')"),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HR_WEB_MEETING",
                columns: table => new
                {
                    req_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dept_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    req_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    req_meeting_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    req_meeting_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    req_content = table.Column<string>(type: "text", nullable: true),
                    req_to = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alt_meeting_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    alt_meeting_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    in_charge = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    meeting_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    meeting_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    meeting_content = table.Column<string>(type: "text", nullable: true),
                    meeting_attendance = table.Column<string>(type: "text", nullable: true),
                    close_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_WEB_MEETING", x => x.req_id);
                });

            migrationBuilder.CreateTable(
                name: "HR_WEB_MEETING_LOG",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    log_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    log_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    log_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    req_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dept_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    req_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    req_meeting_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    req_meeting_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    req_content = table.Column<string>(type: "text", nullable: true),
                    req_to = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alt_meeting_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    alt_meeting_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    in_charge = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    meeting_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    meeting_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    meeting_content = table.Column<string>(type: "text", nullable: true),
                    meeting_attendance = table.Column<string>(type: "text", nullable: true),
                    close_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HR_WEB_OUTSIDE",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_WEB_OUTSIDE", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_WEB_REQUEST",
                columns: table => new
                {
                    seq = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    req_date = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    req_type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    req_sub_type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    period_from = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    period_to = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    days_cnt = table.Column<decimal>(type: "decimal(5,2)", nullable: true, defaultValueSql: "((0))"),
                    hours_cnt = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    start_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    req_title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    req_content = table.Column<string>(type: "text", nullable: true),
                    req_ip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    approve_1st_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    approve_1st_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    approve_1st_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    approve_2nd_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    approve_2nd_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    approve_2nd_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    mhrs_update_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    mhrs_update_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    reject_reason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    reject_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    reject_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    sickday_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_WEB_REQUEST", x => x.seq);
                });

            migrationBuilder.CreateTable(
                name: "HR_WEB_USER",
                columns: table => new
                {
                    empl_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    pw = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    nick_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    login_cnt = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    last_login_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    temp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mms_level = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_WEB_USER", x => x.empl_code);
                });

            migrationBuilder.CreateTable(
                name: "IF_MPS_DETAIL",
                columns: table => new
                {
                    mps_detail_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mps_master_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mps_master_id = table.Column<int>(type: "int", nullable: true),
                    mps_wo_id = table.Column<int>(type: "int", nullable: false),
                    mps_cust_pono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_style_id = table.Column<int>(type: "int", nullable: true),
                    mps_style = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_style_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    mps_color_id = table.Column<int>(type: "int", nullable: true),
                    mps_color_ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_color_actual = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_graphic_style_id = table.Column<int>(type: "int", nullable: true),
                    mps_graphic_style = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_order_qty = table.Column<int>(type: "int", nullable: false),
                    mps_indc_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IF_MPS_D__02EF3B8A108B795B", x => x.mps_detail_sid);
                });

            migrationBuilder.CreateTable(
                name: "IF_MPS_EVENT",
                columns: table => new
                {
                    event_id = table.Column<int>(type: "int", nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cust_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    vend_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    event_desc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    event_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    confirm_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IF_MPS_E__2370F727164452B1", x => x.event_id);
                });

            migrationBuilder.CreateTable(
                name: "IF_MPS_MASTER",
                columns: table => new
                {
                    mps_master_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mps_master_id = table.Column<int>(type: "int", nullable: false),
                    mps_wono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    mps_total_order_qty = table.Column<int>(type: "int", nullable: false),
                    mps_yard_pcs = table.Column<decimal>(type: "numeric(12,3)", nullable: true),
                    mps_season = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_seasonyear = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    mps_contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cust_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    vend_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IF_MPS_M__696BDA0B1BFD2C07", x => x.mps_master_sid);
                });

            migrationBuilder.CreateTable(
                name: "IF_MPS_STAGE",
                columns: table => new
                {
                    mps_master_id = table.Column<int>(type: "int", nullable: true),
                    mps_wo_id = table.Column<int>(type: "int", nullable: true),
                    mps_wono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_cust_pono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_style_id = table.Column<int>(type: "int", nullable: true),
                    mps_style = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_style_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    mps_color_id = table.Column<int>(type: "int", nullable: true),
                    mps_color_ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_color_actual = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_graphic_style_id = table.Column<int>(type: "int", nullable: true),
                    mps_graphic_style = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_order_qty = table.Column<int>(type: "int", nullable: true),
                    mps_ship_out_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    mps_indc_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    mps_due_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    mps_season = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_season_year = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    mps_contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_cust_id = table.Column<int>(type: "int", nullable: true),
                    mps_vend_id = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "IF_MPS_STYLE",
                columns: table => new
                {
                    mps_style_id = table.Column<int>(type: "int", nullable: false),
                    mps_style = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_style_desc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    mps_style_image = table.Column<byte[]>(type: "image", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IF_MPS_S__A812576224927208", x => x.mps_style_id);
                });

            migrationBuilder.CreateTable(
                name: "IF_PROCESS",
                columns: table => new
                {
                    process_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mps_master_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    process_lib_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    seq = table.Column<int>(type: "int", nullable: true),
                    date1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    date2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    target_qty = table.Column<int>(type: "int", nullable: true),
                    target_length = table.Column<decimal>(type: "numeric(12,3)", nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    local_modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    confirm_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    confirm_user_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IF_PROCE__442C2E022A4B4B5E", x => x.process_sid);
                });

            migrationBuilder.CreateTable(
                name: "IF_PROCESS_LIBRARY",
                columns: table => new
                {
                    process_lib_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    vend_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    process_check = table.Column<int>(type: "int", nullable: false),
                    process_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    process_unit = table.Column<int>(type: "int", nullable: false),
                    seq = table.Column<int>(type: "int", nullable: true),
                    date1_check = table.Column<int>(type: "int", nullable: false),
                    date1_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    date2_check = table.Column<int>(type: "int", nullable: false),
                    date2_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    qty1_check = table.Column<int>(type: "int", nullable: false),
                    qty1_unit_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    percentage1_check = table.Column<int>(type: "int", nullable: false),
                    percentage1_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    string1_check = table.Column<int>(type: "int", nullable: false),
                    string1_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IF_PROCE__2EB6FD18300424B4", x => x.process_lib_sid);
                });

            migrationBuilder.CreateTable(
                name: "IF_PROGRESS",
                columns: table => new
                {
                    progress_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    process_sid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mps_cust_pono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_style_id = table.Column<int>(type: "int", nullable: true),
                    mps_style = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_color_id = table.Column<int>(type: "int", nullable: true),
                    mps_color_ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mps_graphic_style_id = table.Column<int>(type: "int", nullable: true),
                    mps_indc_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    base_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    qty1 = table.Column<decimal>(type: "numeric(12,3)", nullable: true),
                    percentage1 = table.Column<decimal>(type: "numeric(12,3)", nullable: true),
                    string1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    local_modified_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    confirm_comment = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    confirm_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    confirm_user_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IF_PROGR__9378576A35BCFE0A", x => x.progress_sid);
                });

            migrationBuilder.CreateTable(
                name: "TA_CODE_MAPPING",
                columns: table => new
                {
                    @class = table.Column<string>(name: "class", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    old_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    new_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TA_CODE_MAPPING", x => new { x.@class, x.old_code });
                });

            migrationBuilder.CreateTable(
                name: "TA_GENERAL_CODE",
                columns: table => new
                {
                    @class = table.Column<string>(name: "class", type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    code = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    sort_no = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    value_1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    value_2 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    value_3 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TA_GENER__E288AC23681373AD", x => new { x.@class, x.code });
                });

            migrationBuilder.CreateTable(
                name: "TA_PERMISSION",
                columns: table => new
                {
                    sys_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    pgm_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    open_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('Y')"),
                    new_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    copy_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    inquiry_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    detail_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    search_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    clear_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    save_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    delete_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    upload_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    excel_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    print_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    help_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TA_PERMI__6F493C5844CA3770", x => new { x.sys_code, x.group_code, x.pgm_code });
                });

            migrationBuilder.CreateTable(
                name: "TA_PROGRAM",
                columns: table => new
                {
                    sys_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    pgm_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    pgm_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    pgm_module = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sort_no = table.Column<int>(type: "int", nullable: true),
                    upper_pgm_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    pgm_type = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    pgm_level = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    form_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    new_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    copy_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    inquiry_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    detail_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    search_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    clear_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    save_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    delete_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    upload_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    excel_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    print_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    help_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
                    remark = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TA_PROGR__ACD370E056E8E7AB", x => new { x.sys_code, x.pgm_code });
                });

            migrationBuilder.CreateTable(
                name: "TA_PW_CONFIRM_SENTENCE",
                columns: table => new
                {
                    type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    confirm_sentence = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    confirm_key = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TA_PW_CONFIRM_SENTENCE", x => x.type);
                });

            migrationBuilder.CreateTable(
                name: "TA_USER",
                columns: table => new
                {
                    user_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    user_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    empl_code = table.Column<string>(type: "char(18)", unicode: false, fixedLength: true, maxLength: 18, nullable: true),
                    org_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cust_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    vend_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    mps_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    priority_level = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    other_org_code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    payroll_org_only = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TA_USER__EDC4140E3C69FB99", x => x.user_code);
                });

            migrationBuilder.CreateTable(
                name: "TA_USER_GROUP",
                columns: table => new
                {
                    user_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    sys_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    group_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    modified_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    modified_user = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TA_USER___0523AFDA22751F6C", x => new { x.user_code, x.sys_code });
                });

            migrationBuilder.CreateTable(
                name: "TA_VERSION",
                columns: table => new
                {
                    sys_id = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    source = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    server_path = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    local_path = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    version = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dll_yn = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TA_VERSI__8A08B5C14222D4EF", x => new { x.sys_id, x.source });
                });

            migrationBuilder.CreateTable(
                name: "TempInsSurf09162022",
                columns: table => new
                {
                    empl_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MainName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InsuredEmployee = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    SpAge = table.Column<double>(type: "float", nullable: true),
                    ChildAge = table.Column<double>(type: "float", nullable: true),
                    Chi20Under = table.Column<int>(type: "int", nullable: true),
                    Chi20Over = table.Column<int>(type: "int", nullable: true),
                    rate_cate = table.Column<double>(type: "float", nullable: true),
                    CovType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    _6BUH = table.Column<decimal>(name: "6BUH", type: "money", nullable: true),
                    _6BRT = table.Column<decimal>(name: "6BRT", type: "money", nullable: true),
                    _6BNT = table.Column<decimal>(name: "6BNT", type: "money", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempInsSurf10112018",
                columns: table => new
                {
                    empl_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MainName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InsuredEmployee = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    age = table.Column<double>(type: "float", nullable: true),
                    SpAge = table.Column<double>(type: "float", nullable: true),
                    ChildAge = table.Column<double>(type: "float", nullable: true),
                    Chi20Under = table.Column<double>(type: "float", nullable: true),
                    Chi20Over = table.Column<double>(type: "float", nullable: true),
                    rate_cate = table.Column<double>(type: "float", nullable: true),
                    CovType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    _300D = table.Column<decimal>(name: "300D", type: "money", nullable: true),
                    _301D = table.Column<decimal>(name: "301D", type: "money", nullable: true),
                    _301V = table.Column<decimal>(name: "301V", type: "money", nullable: true),
                    _302G = table.Column<decimal>(name: "302G", type: "money", nullable: true),
                    _302Q = table.Column<decimal>(name: "302Q", type: "money", nullable: true),
                    _303F = table.Column<decimal>(name: "303F", type: "money", nullable: true),
                    _304R = table.Column<decimal>(name: "304R", type: "money", nullable: true),
                    _304Z = table.Column<decimal>(name: "304Z", type: "money", nullable: true),
                    _3009 = table.Column<decimal>(name: "3009", type: "money", nullable: true),
                    _301R = table.Column<decimal>(name: "301R", type: "money", nullable: true),
                    _304M = table.Column<decimal>(name: "304M", type: "money", nullable: true),
                    _304V = table.Column<decimal>(name: "304V", type: "money", nullable: true),
                    _3057 = table.Column<decimal>(name: "3057", type: "money", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempInsSurfFor2024",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empl_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MainName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InsuredEmployee = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    SpAge = table.Column<int>(type: "int", nullable: true),
                    ChildAge = table.Column<int>(type: "int", nullable: true),
                    Chi20Under = table.Column<int>(type: "int", nullable: true),
                    Chi20Over = table.Column<int>(type: "int", nullable: true),
                    rate_cate = table.Column<double>(type: "float", nullable: true),
                    CovType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    _6RHZ = table.Column<decimal>(name: "6RHZ", type: "money", nullable: true),
                    _6RHB = table.Column<decimal>(name: "6RHB", type: "money", nullable: true),
                    _8NAG = table.Column<decimal>(name: "8NAG", type: "money", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempInsurancePlan2024",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    age = table.Column<int>(type: "int", nullable: true),
                    _6RHZ = table.Column<decimal>(name: "6RHZ", type: "money", nullable: true),
                    _6RHB = table.Column<decimal>(name: "6RHB", type: "money", nullable: true),
                    _8NAG = table.Column<decimal>(name: "8NAG", type: "money", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tempInsurePlan2023",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    _6BUH = table.Column<decimal>(name: "6BUH", type: "money", nullable: true),
                    _6BRT = table.Column<decimal>(name: "6BRT", type: "money", nullable: true),
                    _6BNT = table.Column<decimal>(name: "6BNT", type: "money", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "XX_Label",
                columns: table => new
                {
                    @class = table.Column<string>(name: "class", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    class_sn = table.Column<int>(type: "int", nullable: true),
                    property_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    property_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    model = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    specification = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    product_sn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    purpose = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    empl_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    empl_code = table.Column<double>(type: "float", nullable: true),
                    other_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    seq = table.Column<int>(type: "int", nullable: true),
                    update_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    company = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    dept = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    user_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "XIF1GB_CUSTOMER",
                table: "GB_CUSTOMER",
                column: "org_code");

            migrationBuilder.CreateIndex(
                name: "XIF1GB_VENDOR",
                table: "GB_VENDOR",
                column: "org_code");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMPLOYEE_1",
                table: "HR_EMPLOYEE",
                columns: new[] { "org_code", "active_yn", "status", "div_code", "dept_code" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMPLOYEE_ALL_HISTORY",
                table: "HR_EMPLOYEE_ALL_HISTORY",
                column: "empl_code");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMPLOYEE_APPROVER_1",
                table: "HR_EMPLOYEE_APPROVER",
                columns: new[] { "empl_code", "status" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMPLOYEE_APPROVER_2",
                table: "HR_EMPLOYEE_APPROVER",
                columns: new[] { "approver_1st", "status" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMPLOYEE_APPROVER_3",
                table: "HR_EMPLOYEE_APPROVER",
                columns: new[] { "approver_2nd", "status" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_EVAL_EMPLOYEE_RESULT_1",
                table: "HR_EVAL_EMPLOYEE_RESULT",
                column: "empl_code");

            migrationBuilder.CreateIndex(
                name: "IX_HR_INS_EMPL_PICKED_01",
                table: "HR_INS_EMPL_PICKED",
                columns: new[] { "empl_code", "plan_id", "status", "org_code" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_INS_EMPL_PICKED_02",
                table: "HR_INS_EMPL_PICKED",
                columns: new[] { "surfing_id", "status", "org_code" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_INS_EMPL_SURFING_01",
                table: "HR_INS_EMPL_SURFING",
                columns: new[] { "plan_id", "empl_code", "status", "org_code" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_INS_EMPL_SURFING_02",
                table: "HR_INS_EMPL_SURFING",
                columns: new[] { "empl_code", "status", "org_code" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_PAYROLL_BENEFIT_1",
                table: "HR_PAYROLL_BENEFIT",
                columns: new[] { "pay_date", "empl_code" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_PTO_FOR_INET_01",
                table: "HR_PTO_FOR_INET",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_HR_TNA_BADGE_01",
                table: "HR_TNA_BADGE",
                columns: new[] { "date", "group_code", "person_id" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_TNA_DAY_1",
                table: "HR_TNA_DAY",
                columns: new[] { "date", "org_code", "day_type", "empl_code" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_TNA_TIME_1",
                table: "HR_TNA_TIME",
                columns: new[] { "empl_code", "org_code", "date" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_TNA_TIME_2",
                table: "HR_TNA_TIME",
                columns: new[] { "date", "late_level" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_WEB_USER_1",
                table: "HR_WEB_USER",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "XIF1IF_MPS_DETAIL",
                table: "IF_MPS_DETAIL",
                column: "mps_master_sid");

            migrationBuilder.CreateIndex(
                name: "XIF1IF_MPS_MASTER",
                table: "IF_MPS_MASTER",
                columns: new[] { "cust_code", "org_code" });

            migrationBuilder.CreateIndex(
                name: "XIF2IF_MPS_MASTER",
                table: "IF_MPS_MASTER",
                columns: new[] { "vend_code", "org_code" });

            migrationBuilder.CreateIndex(
                name: "XIF1IF_PROCESS",
                table: "IF_PROCESS",
                column: "process_lib_sid");

            migrationBuilder.CreateIndex(
                name: "XIF4IF_PROCESS",
                table: "IF_PROCESS",
                column: "mps_master_sid");

            migrationBuilder.CreateIndex(
                name: "XIF5IF_PROCESS",
                table: "IF_PROCESS",
                column: "user_code");

            migrationBuilder.CreateIndex(
                name: "XIF1IF_PROCESS_LIBRARY",
                table: "IF_PROCESS_LIBRARY",
                column: "org_code");

            migrationBuilder.CreateIndex(
                name: "XIF2IF_PROCESS_LIBRARY",
                table: "IF_PROCESS_LIBRARY",
                columns: new[] { "vend_code", "org_code" });

            migrationBuilder.CreateIndex(
                name: "XIF1IF_PROGRESS",
                table: "IF_PROGRESS",
                column: "process_sid");

            migrationBuilder.CreateIndex(
                name: "XIF2IF_PROGRESS",
                table: "IF_PROGRESS",
                column: "user_code");

            migrationBuilder.CreateIndex(
                name: "XIF1TA_USER",
                table: "TA_USER",
                columns: new[] { "cust_code", "org_code" });

            migrationBuilder.CreateIndex(
                name: "XIF2TA_USER",
                table: "TA_USER",
                columns: new[] { "vend_code", "org_code" });

            migrationBuilder.CreateIndex(
                name: "XIF3TA_USER",
                table: "TA_USER",
                column: "org_code");
        */}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GB_CUSTOMER");

            migrationBuilder.DropTable(
                name: "GB_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "GB_DIVISION");

            migrationBuilder.DropTable(
                name: "GB_ORGANIZATION");

            migrationBuilder.DropTable(
                name: "GB_ORGANIZATION_NUMBER");

            migrationBuilder.DropTable(
                name: "GB_TASK");

            migrationBuilder.DropTable(
                name: "GB_TASK_MEMBER");

            migrationBuilder.DropTable(
                name: "GB_VENDOR");

            migrationBuilder.DropTable(
                name: "HR_ASSIGNED_PROPERTY");

            migrationBuilder.DropTable(
                name: "HR_AUTO_ACCIDENT");

            migrationBuilder.DropTable(
                name: "HR_CONTACT");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_ALL_HISTORY");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_APPROVER");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_CAREER");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_DETAIL");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_EDUCATION");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_HISTORY");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_PLAN");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_RP");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_SCANIMAGE");

            migrationBuilder.DropTable(
                name: "HR_EMPLOYEE_SKILL");

            migrationBuilder.DropTable(
                name: "HR_EVAL_BASIC");

            migrationBuilder.DropTable(
                name: "HR_EVAL_EMPLOYEE_RESULT");

            migrationBuilder.DropTable(
                name: "HR_EVAL_EMPLOYEE_SUMMARY");

            migrationBuilder.DropTable(
                name: "HR_EVAL_FACTOR");

            migrationBuilder.DropTable(
                name: "HR_EVAL_FACTOR_DETAIL");

            migrationBuilder.DropTable(
                name: "HR_EVAL_FACTOR_MAPPING");

            migrationBuilder.DropTable(
                name: "HR_EVAL_GROUP");

            migrationBuilder.DropTable(
                name: "HR_EVAL_GROUP_DEPT");

            migrationBuilder.DropTable(
                name: "HR_EVAL_GROUP_RESULT");

            migrationBuilder.DropTable(
                name: "HR_EVAL_HALF_RESULT");

            migrationBuilder.DropTable(
                name: "HR_EVAL_HALF_RESULT_LOG");

            migrationBuilder.DropTable(
                name: "HR_EVAL_MANAGER");

            migrationBuilder.DropTable(
                name: "HR_EVAL_PROMOTION_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "HR_EVAL_SELF_RESULT");

            migrationBuilder.DropTable(
                name: "HR_EVAL_SELF_SUMMARY");

            migrationBuilder.DropTable(
                name: "HR_EVAL_YEAR_RESULT");

            migrationBuilder.DropTable(
                name: "HR_EVAL_YEAR_RESULT_LOG");

            migrationBuilder.DropTable(
                name: "HR_GENERAL_CODE");

            migrationBuilder.DropTable(
                name: "HR_HOLIDAY");

            migrationBuilder.DropTable(
                name: "HR_INCIDENT");

            migrationBuilder.DropTable(
                name: "HR_INS_EMPL_PICKED");

            migrationBuilder.DropTable(
                name: "HR_INS_EMPL_SURFING");

            migrationBuilder.DropTable(
                name: "HR_INS_NOT_ENROLL");

            migrationBuilder.DropTable(
                name: "HR_INS_PLAN");

            migrationBuilder.DropTable(
                name: "HR_LOCKER");

            migrationBuilder.DropTable(
                name: "HR_PARKING_LOT");

            migrationBuilder.DropTable(
                name: "HR_PAYROLL");

            migrationBuilder.DropTable(
                name: "HR_PAYROLL_BENEFIT");

            migrationBuilder.DropTable(
                name: "HR_PAYROLL_BONUS");

            migrationBuilder.DropTable(
                name: "HR_POLICY");

            migrationBuilder.DropTable(
                name: "HR_POLICY_CONSENT_LOG");

            migrationBuilder.DropTable(
                name: "HR_PTO_FOR_INET");

            migrationBuilder.DropTable(
                name: "HR_TNA_BADGE");

            migrationBuilder.DropTable(
                name: "HR_TNA_DAY");

            migrationBuilder.DropTable(
                name: "HR_TNA_EMAIL_NOTICE");

            migrationBuilder.DropTable(
                name: "HR_TNA_INOUT");

            migrationBuilder.DropTable(
                name: "HR_TNA_START_TIME");

            migrationBuilder.DropTable(
                name: "HR_TNA_TIME");

            migrationBuilder.DropTable(
                name: "HR_TRANSACTION");

            migrationBuilder.DropTable(
                name: "HR_VACATION");

            migrationBuilder.DropTable(
                name: "HR_VACATION_20150707");

            migrationBuilder.DropTable(
                name: "HR_WEB_LOGIN_LOG");

            migrationBuilder.DropTable(
                name: "HR_WEB_MEETING");

            migrationBuilder.DropTable(
                name: "HR_WEB_MEETING_LOG");

            migrationBuilder.DropTable(
                name: "HR_WEB_OUTSIDE");

            migrationBuilder.DropTable(
                name: "HR_WEB_REQUEST");

            migrationBuilder.DropTable(
                name: "HR_WEB_USER");

            migrationBuilder.DropTable(
                name: "IF_MPS_DETAIL");

            migrationBuilder.DropTable(
                name: "IF_MPS_EVENT");

            migrationBuilder.DropTable(
                name: "IF_MPS_MASTER");

            migrationBuilder.DropTable(
                name: "IF_MPS_STAGE");

            migrationBuilder.DropTable(
                name: "IF_MPS_STYLE");

            migrationBuilder.DropTable(
                name: "IF_PROCESS");

            migrationBuilder.DropTable(
                name: "IF_PROCESS_LIBRARY");

            migrationBuilder.DropTable(
                name: "IF_PROGRESS");

            migrationBuilder.DropTable(
                name: "TA_CODE_MAPPING");

            migrationBuilder.DropTable(
                name: "TA_GENERAL_CODE");

            migrationBuilder.DropTable(
                name: "TA_PERMISSION");

            migrationBuilder.DropTable(
                name: "TA_PROGRAM");

            migrationBuilder.DropTable(
                name: "TA_PW_CONFIRM_SENTENCE");

            migrationBuilder.DropTable(
                name: "TA_USER");

            migrationBuilder.DropTable(
                name: "TA_USER_GROUP");

            migrationBuilder.DropTable(
                name: "TA_VERSION");

            migrationBuilder.DropTable(
                name: "TempInsSurf09162022");

            migrationBuilder.DropTable(
                name: "TempInsSurf10112018");

            migrationBuilder.DropTable(
                name: "TempInsSurfFor2024");

            migrationBuilder.DropTable(
                name: "tempInsurancePlan2024");

            migrationBuilder.DropTable(
                name: "tempInsurePlan2023");

            migrationBuilder.DropTable(
                name: "XX_Label");
        }
    }
}
