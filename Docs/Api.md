# API Endpoints

## Contents
- [API Endpoints](#api-endpoints)
  - [Contents](#contents)
  - [Manager](#manager)
    - [Read managed employee `emplCode` list request](#read-managed-employee-emplcode-list-request)
  - [Employee Info](#employee-info)
    - [Read employee info by `emplCode` request](#read-employee-info-by-emplcode-request)
    - [Read transfer history by `emplCode` request](#read-transfer-history-by-emplcode-request)
    - [Read awards \& disciplinary actions by `emplCode` request](#read-awards--disciplinary-actions-by-emplcode-request)
    - [Read full employee list request](#read-full-employee-list-request)
    - [Update password request](#update-password-request)
  - [Day/Time Off](#daytime-off)
    - [Get all day time off request for given employee by `emplCode`](#get-all-day-time-off-request-for-given-employee-by-emplcode)
    - [Create new day time off request](#create-new-day-time-off-request)
    - [Update day time off request](#update-day-time-off-request)
    - [Get day time off request by `id`](#get-day-time-off-request-by-id)
    - [Delete day time off request by `id`](#delete-day-time-off-request-by-id)
    - [Get remaining vacation days by `emplCode` and `year`](#get-remaining-vacation-days-by-emplcode-and-year)
    - [Read vacation history by `emplCode`](#read-vacation-history-by-emplcode)
    - [Get list of current day time off request by `emplCode`, `year`](#get-list-of-current-day-time-off-request-by-emplcode-year)
    - [Read list of pending day/time off approval requests for manager by `managerEmplCode`](#read-list-of-pending-daytime-off-approval-requests-for-manager-by-manageremplcode)
    - [Read list of day/time off approval history for manager by `managerEmplCode`](#read-list-of-daytime-off-approval-history-for-manager-by-manageremplcode)
    - [Read day/time off approval history by `emplCode` request](#read-daytime-off-approval-history-by-emplcode-request)
  - [Time \& Attendance](#time--attendance)
    - [Read time \& attendance history by `emplCode`, `time_period` request](#read-time--attendance-history-by-emplcode-time_period-request)
  - [HR Request](#hr-request)
    - [Read list of HR requests by `emplCode`, `year` request](#read-list-of-hr-requests-by-emplcode-year-request)
    - [Create new HR meeting request request](#create-new-hr-meeting-request-request)
    - [Read list of pending HR meeting requests for manager by  request`approver_id`](#read-list-of-pending-hr-meeting-requests-for-manager-by--requestapprover_id)
    - [Read HR meeting history by `emplCode`, `year` request](#read-hr-meeting-history-by-emplcode-year-request)
  - [Org Chart](#org-chart)
    - [GET /org\_chart/data request](#get-org_chartdata-request)
  - [Insurance](#insurance)
    - [Read selected insurance information by `emplCode` request](#read-selected-insurance-information-by-emplcode-request)
    - [Read insurance surfing data by `emplCode`, `coverage_selection` request](#read-insurance-surfing-data-by-emplcode-coverage_selection-request)
  - [Evaluation](#evaluation)
    - [Create new self evaluation request](#create-new-self-evaluation-request)

## Manager

### Read managed employee `emplCode` list request

```js
GET /manager/emplCode_list/{approver_id}
```

Endpoint to retrieve employee codes associated with a specific approver (for managers).

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "emplCodes": ["l000111", "l000112", "1000113"]
}
```

## Employee Info

### Read employee info by `emplCode` request

```js
GET /employee_info/info/{emplCode}
```

Endpoint to retrieve employee information based on their employee code.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "emplCode": "1000123",
  "emplName": "John Doe",
  "divName": "Division XYZ",
  "dept1Name": "Department A",
  "deptName": "Sub-Department X",
  "comTel": "123-456-7890",
  "comTelExt": "1234",
  "comFax": "987-654-3210",
  "comEmail": "john.doe@example.com",
  "hireDate2": "2020-05-15",
  "title": "Software Engineer",
  "flsas": "Exempt",
  "birthDate2": "1985-08-20",
  "street": "1234 Elm St",
  "cityStateZip": "Somewhere, CA 12345",
  "tel": "555-555-5555",
  "cell": "555-123-4567",
  "contact1Name": "Mary Smith",
  "contact1RelDesc": "Emergency Contact",
  "contact1Addr1": "5678 Oak St",
  "contact1Addr2": "Apt 101",
  "contact1Tel": "555-987-6543",
  "contact1Cell": "555-876-5432"
}

```

### Read transfer history by `emplCode` request

```js
GET /employee_info/transfer_history/{emplCode}
```

Endpoint to retrieve the transfer history of an employee based on their employee code.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "transfer_history": [
    {
      "date": "2023-07-15",
      "from_department": "Sales",
      "to_department": "Marketing"
    },
    {
      "date": "2022-12-10",
      "from_department": "HR",
      "to_department": "Sales"
    }
  ]
}
```

### Read awards & disciplinary actions by `emplCode` request

```js
GET /award_disciplinary_action/{emplCode}
```

Endpoint to retrieve awards and disciplinary actions of an employee based on their employee code.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "awards": ["Employee of the Month - Jan 2023"],
  "disciplinary_actions": ["Written Warning - Mar 2022"]
}
```

### Read full employee list request

```js
GET /employee_list
```

Endpoint to retrieve a list of employees.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "employees": [
    {
      "employee_id": "empl001",
      "name": "John Doe"
    },
    {
      "employee_id": "empl002",
      "name": "Jane Smith"
    }
  ]
}
```

### Update password request

```js
POST /login/password_change
```

Endpoint to allow employees to change their login password.

**Sample Request:**

```json
{
  "employee_id": "empl001",
  "new_password": "newpassword123"
}
```

**Sample Response:**

```json
{
  "message": "Password changed successfully."
}
```

## Day/Time Off

### Get all day time off request for given employee by `emplCode`
```js
GET /api/DayTimeOffRequest/GetAllEmployeeDayTimeOffRequestList/{emplCode}
```

Endpoint to get list of day/time off requests for a given employee.

**Parameters:**
```js
emplCode : String
```

**Sample Response**
```json
[
  {
    "seq": 1,
    "status": 2,
    "emplCode": "EMP001",
    "reqDate": "20220101",
    "reqType": "PTO",
    "reqSubType": "PTO [ PM ] ",
    "periodFrom": "20220102",
    "periodTo": "20220102",
    "daysCnt": 0.5,
    "hoursCnt": 0,
    "startTime": null,
    "reqTitle": "",
    "reqContent": "",
    "reqIp": "192.168.1.1",
    "approve1stYn": "Y",
    "approve1stUser": "MGR001",
    "approve1stDate": "2022-01-01T10:00:00.000",
    "approve2ndYn": "Y",
    "approve2ndUser": "HR001",
    "approve2ndDate": "2022-01-01T11:00:00.000",
    "mhrsUpdateYn": "Y",
    "mhrsUpdateUser": "HR001",
    "rejectReason": null,
    "rejectUser": null,
    "rejectDate": null,
    "sickdayYn": "N",
    "createdDate": "2022-01-01T09:00:00.000",
    "createdUser": "EMP001",
    "modifiedDate": "2022-01-01T11:30:00.000",
    "modifiedUser": "HR001"
  },
  {
    "seq": 2,
    "status": 2,
    "emplCode": "EMP002",
    "reqDate": "20220103",
    "reqType": "PTO",
    "reqSubType": "PTO [ PM ] ",
    "periodFrom": "20220104",
    "periodTo": "20220104",
    "daysCnt": 0.5,
    "hoursCnt": 0,
    "startTime": null,
    "reqTitle": "",
    "reqContent": "",
    "reqIp": "192.168.1.2",
    "approve1stYn": "Y",
    "approve1stUser": "MGR002",
    "approve1stDate": "2022-01-03T10:00:00.000",
    "approve2ndYn": "Y",
    "approve2ndUser": "HR002",
    "approve2ndDate": "2022-01-03T11:00:00.000",
    "mhrsUpdateYn": "Y",
    "mhrsUpdateUser": "HR002",
    "rejectReason": null,
    "rejectUser": null,
    "rejectDate": null,
    "sickdayYn": "N",
    "createdDate": "2022-01-03T09:00:00.000",
    "createdUser": "EMP002",
    "modifiedDate": "2022-01-03T11:30:00.000",
    "modifiedUser": "HR002"
  }
]
```

### Create new day time off request

```js
POST /api/DayTimeOffRequest/CreateDayTimeOffRequest
```

TODO: Endpoint to submit a new day/time off request.

**Sample Request:**

```json
{
  "emplCode": "EMPL001",
  "type": "Vacation",
  "subType": "Paid",
  "fromDate": "2023-10-15",
  "toDate": "2023-10-17",
  "daysCnt": 3.0,
  "title": "Vacation Request",
  "content": "Taking a short vacation to relax.",
  "ip": "192.168.1.100",
  "user": "john.doe",
  "newType": "Vacation",
  "seq": 1,
  "hours": 24,
  "time": "08:00:00",
  "sickDayYnN": "N"
}
```

**Sample Response:**

```json
{
  "id" : 123456000
}
```

### Update day time off request

```js
POST /api/DayTimeOffRequest/UpdateDayTimeOffRequest/{id}
```

TODO: Endpoint to update an existing day/time off request.

**Parameters:**
```js
id : int
```

**Sample Request:**

```json
{
  "emplCode": "EMPL001",
  "type": "Vacation",
  "subType": "Paid",
  "fromDate": "2023-10-15",
  "toDate": "2023-10-17",
  "daysCnt": 3.0,
  "title": "Vacation Request",
  "content": "Taking a short vacation to relax.",
  "ip": "192.168.1.100",
  "user": "john.doe",
  "newType": "Vacation",
  "seq": 1,
  "hours": 24,
  "time": "08:00:00",
  "sickDayYnN": "N"
}
```

**Sample Response:**

```json
{
  "id" : 123456000
}
```

### Get day time off request by `id`

```js
POST /api/DayTimeOffRequest/GetDayTimeOffRequest/{id}
```

Endpoint to get an existing day/time off request.

**Parameters:**
```js
id : int
```

**Sample Response:**

```json
{
  "emplCode": "EMPL001",
  "type": "Vacation",
  "subType": "Paid",
  "fromDate": "2023-10-15",
  "toDate": "2023-10-17",
  "daysCnt": 3.0,
  "title": "Vacation Request",
  "content": "Taking a short vacation to relax.",
  "ip": "192.168.1.100",
  "user": "john.doe",
  "newType": "Vacation",
  "seq": 1,
  "hours": 24,
  "time": "08:00:00",
  "sickDayYnN": "N"
}
```

### Delete day time off request by `id`

```js
POST /api/DayTimeOffRequest/DeleteDayTimeOffRequest/{id}
```

TODO: Endpoint to delete an existing day/time off request.

**Parameters:**
```js
id : int
```

**Sample Response:**

```json
{
  1
}
```

### Get remaining vacation days by `emplCode` and `year`

```js
GET /api/DayTimeOffRequest/GetDayTimeOffRemainingByEmployee/{emplCode}/{year}
```

Endpoint to retrieve vacation days for a given employee based on their employee code and given year.

**Parameters:**

```
emplCode : string
year : string
```

**Sample Response:**

```json
{
  "div_name": "COO",
  "dept_name": "IT",
  "emplCode": 1234000,
  "name": "Doe, John",
  "hire_date": "11/11/2011 00:00:00",
  "s_carry_over_days": 0,
  "s_year_basic_days": 0.0,
  "prev_month_day": 0.0,
  "accu_days": 0.0,
  "s_curr_basic_days": 0.0,
  "s_adjust_days": 0,
  "s_used_days": 0.0,
  "s_available_days": 0.0,
  "s_available_curr_days": 0.0,
  "s_available_curr_hrs": 0,
  "yyyy": "2023",
  "s_left_days": 0.0,
  "s_hold_days": 0,
  "s_available_days_span": "<span style=\"color:#0000ff;\">",
  "s_available_curr_days_span": "<span style=\"color:#0000ff;\">",
  "payroll_org_code": "MIAS",
  "s_available_asof_date": 0,
  "s_uto_days": 0.0,
  "s_uto_applied_days": 0.0,
  "resign_date": "12/31/9998 00:00:00",
  "s_sick_days": 0,
  "s_used_sick_days": 0,
  "org_available_days": 0.0
}
```

### Read vacation history by `emplCode`

```js
GET /api/DayTimeOffRequest/GetEmployeeDayTimeOffHistoryList/{emplCode}/{year}
```

Endpoint to retrieve vacation history for an employee based on their employee code.

**Parameters:**

```
emplCode : string
year : string
```

**Sample Response:**

```json
[
  {
    "seq": 0,
    "yyyy": "2023",
    "v_type_desc": "ABSENCE",
    "carry_over_days": 0,
    "basic_days": 0,
    "hold_days": 0,
    "adjust_days": 0,
    "used_days": 0,
    "remark": "sick call",
    "v_type": "USED"
  },
  {
    "seq": 0,
    "yyyy": "2023",
    "v_type_desc": "ABSENCE - 2Hrs",
    "carry_over_days": 0,
    "basic_days": 0,
    "hold_days": 0,
    "adjust_days": 0,
    "used_days": 0,
    "remark": "",
    "v_type": "USED"
  },
]
```

### Get list of current day time off request by `emplCode`, `year`

```js
GET /api/DayTimeOffRequest/GetDayTimeOffRequestResultList{emplCode}/{year}
```

Endpoint to retrieve a list of day/time off requests for a specific employee and year.

**Parameters:**

```
emplCode : string
year : string
```

**Sample Response:**

```json
[
  {
    "seq": 12345,
    "req_date": "20230201",
    "req_type": "VAC",
    "req_sub_type": "VAC - 6 Hrs, @ 8:00 AM (by HR)",
    "period_from": "20230201",
    "period_to": "20230201",
    "days_cnt": 1.0,
    "hours_cnt": 8,
    "start_time": "08:00:00",
    "req_title": "",
    "req_content": "sick call",
    "req_ip": "",
    "approve_1st_yn": "Y",
    "approve_1st_user": "100123",
    "approve_1st_date": "2023-02-02T10:17:51.693",
    "approve_2nd_yn": "Y",
    "approve_2nd_user": "100001",
    "approve_2nd_date": "2023-02-02T10:17:51.703",
    "mhrs_update_yn": "Y",
    "mhrs_update_user": "JANE BROWN",
    "reject_reason": null,
    "reject_user": null,
    "reject_date": null,
    "sickday_yn": "Y",
    "req_date2": "02/02/2023",
    "period": "02/02/2023 - 02/02/2023",
    "req_status": "[ APPROVED ]",
    "req_content2": "sick call",
    "req_content3": "sick call"
  },
  {
    "seq": 12345,
    "req_date": "20230905",
    "req_type": "VAC",
    "req_sub_type": "VAC - 6 Hrs, @ 8:00 AM (by HR)",
    "period_from": "20230905",
    "period_to": "20230905",
    "days_cnt": 1.0,
    "hours_cnt": 8,
    "start_time": "08:00:00",
    "req_title": "",
    "req_content": "sick call",
    "req_ip": "",
    "approve_1st_yn": "Y",
    "approve_1st_user": "100123",
    "approve_1st_date": "2023-09-05T10:17:51.693",
    "approve_2nd_yn": "Y",
    "approve_2nd_user": "100001",
    "approve_2nd_date": "2023-09-05T10:17:51.703",
    "mhrs_update_yn": "Y",
    "mhrs_update_user": "JANE BROWN",
    "reject_reason": null,
    "reject_user": null,
    "reject_date": null,
    "sickday_yn": "Y",
    "req_date2": "09/05/2023",
    "period": "09/05/2023 - 09/05/2023",
    "req_status": "[ APPROVED ]",
    "req_content2": "sick call",
    "req_content3": "sick call"
  }
]
```

### Read list of pending day/time off approval requests for manager by `managerEmplCode`

```js
GET /api/manager/DayTimeOffRequest/GetPendingDayTimeOffRequestList{managerEmplCode}
```

Endpoint to retrieve a list of day/time off approval requests for a manager.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  [
    {
      "seq": 0,
      "status": 0,
      "emplCode": "1230000",
      "req_date": "2023-10-15",
      "req_type": "Vacation",
      "req_sub_type": "Paid",
      "period_from": "2023-11-15",
      "period_to": "2023-11-20",
      "days_cnt": 5,
      "hours_cnt": 40,
      "start_time": {
        "ticks": 0,
        "days": 0,
        "hours": 0,
        "milliseconds": 0,
        "microseconds": 0,
        "nanoseconds": 0,
        "minutes": 0,
        "seconds": 0,
        "totalDays": 0,
        "totalHours": 0,
        "totalMilliseconds": 0,
        "totalMicroseconds": 0,
        "totalNanoseconds": 0,
        "totalMinutes": 0,
        "totalSeconds": 0
      },
      "req_title": "",
      "req_content": "",
      "req_ip": "",
      "approve_1st_yn": "Y",
      "approve_1st_user": "100012",
      "approve_1st_date": "2023-10-30T16:18:20.398Z",
      "approve_2nd_yn": "Y",
      "approve_2nd_user": "100012",
      "approve_2nd_date": "2023-10-30T16:18:20.398Z",
      "mhrs_update_yn": "Y",
      "mhrs_update_user": "string",
      "reject_reason": null,
      "reject_user": null,
      "reject_date": null,
      "sickday_yn": "N",
      "created_date": "2023-10-30T16:18:20.398Z",
      "created_user": "Doe, John",
      "modified_date": "2023-10-30T16:18:20.398Z",
      "modified_user": "Doe, John",
      "approve_type": "string",
      "req_date2": "string",
      "period": "string",
      "pto_left_days": 0,
      "pto_curr_days": 0,
      "sick_left_days": 0,
      "sick_curr_days": 0,
      "empl_name": "Doe, John"
    }
  ]
}
```


### Read list of day/time off approval history for manager by `managerEmplCode`

```js
GET /api/manager/DayTimeOffRequest/GetDayTimeOffApprovalHistory{managerEmplCode}
```

Endpoint to retrieve approval history for a specific employee (for managers).

**Parameters:**

```
managerEmplCode : string
```

**Sample Response:**

```json
[
  {
    "seq": 13371,
    "req_date": "20230913",
    "req_trpe": null,
    "req_sub_type": "VAC - 6 Hrs, @ 8:00 AM (by HR)",
    "period_from": "20230913",
    "period_to": "20230913",
    "days_cnt": 0.75,
    "hours_cnt": 6,
    "start_time": "08:00:00",
    "req_title": "",
    "req_content": "sick call",
    "req_ip": "",
    "approve_1st_yn": "Y",
    "approve_1st_user": "100048",
    "approve_1st_date": "2023-09-13T10:17:51.693",
    "approve_2nd_yn": "Y",
    "approve_2nd_user": "100048",
    "approve_2nd_date": "2023-09-13T10:17:51.703",
    "mhrs_update_yn": "Y",
    "mhrs_update_user": "PAULCHEONG",
    "reject_reason": null,
    "reject_user": null,
    "reject_date": null,
    "sickday_yn": "N",
    "empl_name": "JOHN DOE",
    "req_date2": "09/13/2023",
    "period": "09/13/2023 - 09/13/2023 (0.75)",
    "req_status": "[ APPROVED ]",
    "req_content2": "sick call",
    "req_content3": "sick call"
  },
  {
    "seq": 13367,
    "req_date": "20230911",
    "req_trpe": null,
    "req_sub_type": "Business Related (by HR)",
    "period_from": "20230911",
    "period_to": "20230911",
    "days_cnt": 1,
    "hours_cnt": 0,
    "start_time": null,
    "req_title": "",
    "req_content": "remote work",
    "req_ip": "",
    "approve_1st_yn": "Y",
    "approve_1st_user": "100048",
    "approve_1st_date": "2023-09-11T10:14:33.777",
    "approve_2nd_yn": "Y",
    "approve_2nd_user": "100048",
    "approve_2nd_date": "2023-09-11T10:14:33.787",
    "mhrs_update_yn": "Y",
    "mhrs_update_user": "PAULCHEONG",
    "reject_reason": null,
    "reject_user": null,
    "reject_date": null,
    "sickday_yn": "N",
    "empl_name": "JANE DOE",
    "req_date2": "09/11/2023",
    "period": "09/11/2023 - 09/11/2023 (1.00)",
    "req_status": "[ APPROVED ]",
    "req_content2": "remote work",
    "req_content3": "remote work"
  }
]
```

### Read day/time off approval history by `emplCode` request

```js
GET /day_time_off/approval_history/{emplCode}
```

Endpoint to retrieve approval history for a specific employee (for managers).

**Parameters:**

```
managerEmplCode : string
```

**Sample Response:**

```json
```

## Time & Attendance

### Read time & attendance history by `emplCode`, `time_period` request

```js
GET /time_attendance/history/{emplCode}/{time_period}
```

Endpoint to retrieve time and attendance history for an employee based on their employee code and a specified time period.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "attendance_history": [
    {
      "date": "2023-09-01",
      "hours_worked": 8
    },
    {
      "date": "2023-09-02",
      "hours_worked": 7.5
    }
  ]
}
```

## HR Request

### Read list of HR requests by `emplCode`, `year` request

```js
GET /hr_request/meeting_list/{emplCode}/{year}
```

Endpoint to retrieve a list of HR meeting requests for a specific employee and year.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "meeting_requests": [
    {
      "meeting_id": "meeting001",
      "date": "2023-10-10",
      "status": "Pending"
    },
    {
      "meeting_id": "meeting002",
      "date": "2023-11-05",
      "status": "Approved"
    }
  ]
}
```

### Create new HR meeting request request

```js
POST /hr_request/new_meeting_request
```

Endpoint to submit a new HR meeting request.

**Sample Request:**

```json
{
  "employee_id": "empl001",
  "meeting_date": "2023-12-15",
  "description": "Discuss annual performance"
}
```

**Sample Response:**

```json
{
  "message": "HR meeting request submitted successfully."
}
```

### Read list of pending HR meeting requests for manager by  request`approver_id`

```js
GET /hr_request/waiting_list/{approver_id}
```

Endpoint to retrieve a list of HR meeting requests awaiting approval for a manager.

**Sample Request:**

No request body for this endpoint.


**Sample Response:**

```json
{
  "meeting_requests": [
    {
      "meeting_id": "meeting003",
      "employee_id": "empl003",
      "date": "2023-11-20",
      "status": "Pending"
    }
  ]
}
```


### Read HR meeting history by `emplCode`, `year` request

```js
GET /hr_request/meeting_history/{emplCode}/{year}
```

Endpoint to retrieve HR meeting history for a specific employee and year.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "attendance_history": [
    {
      "date": "2023-09-01",
      "hours_worked": 8
    },
    {
      "date": "2023-09-02",
      "hours_worked": 7.5
    }
  ]
}
```


## Org Chart

### GET /org_chart/data request

Endpoint to retrieve organizational chart data.
**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "meeting_requests": [
    {
      "meeting_id": "meeting001",
      "date": "2023-10-10",
      "status": "Pending"
    },
    {
      "meeting_id": "meeting002",
      "date": "2023-11-05",
      "status": "Approved"
    }
  ]
}
```

## Insurance

### Read selected insurance information by `emplCode` request

```js
GET /insurance/current_selection/{emplCode}
```

Endpoint to retrieve the currently selected insurance information.
**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "insurance_plan": "Health Insurance Plan A",
  "coverage": "Family"
}
```

### Read insurance surfing data by `emplCode`, `coverage_selection` request

```js
GET /insurance_surfing/{emplCode}{coverage_selection}
```

Endpoint to retrieve insurance surfing data based on employee code and coverage selection.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "insurance_plan": "Health Insurance Plan A",
  "coverage": "Individual"
}
```

## Evaluation

### Create new self evaluation request

```js
POST /self_evaluation/new_evaluation
```

Endpoint to submit a self-evaluation.
**Sample Request:**

```json
{
  "employee_id": "empl001",
  "evaluation_date": "2023-09-28",
  "performance_rating": 4.7,
  "comments": "Consistently met and exceeded project goals."
}
```

**Sample Response:**

```json
{
  "message": "Self-evaluation submitted successfully."
}
```