# API Endpoints

## Contents
- [API Endpoints](#api-endpoints)
  - [Contents](#contents)
  - [Manager](#manager)
    - [Read managed employee `emplCode` list request](#read-managed-employee-emplcode-list-request)
  - [Employee Info](#employee-info)
    - [Read basic employee info by `emplCode` request](#read-basic-employee-info-by-emplcode-request)
    - [Read detailed employee info by `emplCode` request](#read-detailed-employee-info-by-emplcode-request)
    - [Read transfer history by `emplCode` request](#read-transfer-history-by-emplcode-request)
    - [Read awards \& disciplinary actions by `emplCode` request](#read-awards--disciplinary-actions-by-emplcode-request)
    - [Read full employee list request](#read-full-employee-list-request)
    - [Update password request](#update-password-request)
  - [Day/Time Off](#daytime-off)
    - [Read vacation days by `emplCode` request](#read-vacation-days-by-emplCode-request)
    - [Read vacation schedule by `emplCode` request](#read-vacation-schedule-by-emplCode-request)
    - [Create new day/time off request request](#create-new-daytime-off-request-request)
    - [Read day/time off request list by `emplCode`, `year` request](#read-daytime-off-request-list-by-emplCode-year-request)
    - [Read list of day/time off approval requests for manager by  request`approver_id`](#read-list-of-daytime-off-approval-requests-for-manager-by--requestapprover_id)
    - [Read day/time off approval history by `emplCode` request](#read-daytime-off-approval-history-by-emplCode-request)
  - [Time \& Attendance](#time--attendance)
    - [Read time \& attendance history by `emplCode`, `time_period` request](#read-time--attendance-history-by-emplCode-time_period-request)
  - [Org Chart](#org-chart)
    - [GET /org\_chart/data request](#get-org_chartdata-request)
  - [Insurance](#insurance)
    - [Read selected insurance information by `emplCode` request](#read-selected-insurance-information-by-emplCode-request)
    - [Read insurance surfing data by `emplCode`, `coverage_selection` request](#read-insurance-surfing-data-by-emplCode-coverage_selection-request)
    - [Update insurance information for employee by `insuranceType`,`emplCode`, `coverageSelection`, `selectedSurfingId` request](#update-insurance-information-for-employee-by-insuranceType-emplCode-coverageSelection-selectedSurfingId-request)
  - [Evaluation](#evaluation)
    - [Get evaluation factors](#get-evaluation-factors)
    - [Create self evaluation record](#create-self-evaluation-record)

## Manager

### Read managed employee `emplCode` list request

```js
GET /EmployeeInfoRequest/GetManagerEmployeeList/{emplCode}
```

Endpoint to retrieve employees under the supervisor (emplCode)

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
 {
    "emplCode": "100041",
    "last_name": "KIM",
    "first_name": "MINSOO",
    "empl_name": "(UNI)"
  }
```

## Employee Info

### Read basic employee info by `emplCode` request

```js
GET /EmployeeInfoRequest/GetBasicEmployeeinfo/{emplCode}
```

Endpoint to retrieve simple employee information based on their employee code.

**Parameters**
```json
{
  "emplCode": "string"
}
```

**Sample Response:**

```json
{
  "emplCode": "100834",
  "orgCode": "MIAS",
  "emplType": "E",
  "status": 1,
  "activeYn": "Y",
  "firstName": "MINSOO",
  "middleName": "",
  "lastName": "HAN",
  "nickName": "CHRIS",
  "divCode": "COO",
  "deptCode": "COO_20",
  "upperEmplCode": "100048",
  "comTel": "(112)112-1234",
  "comTelExt": "112",
  "comFax": "(452)232-1235",
  "comEmail": "bk.h@miasfashion.com",
  "position": "G6",
  "positionYrs": "1",
  "buildingLoc": "",
  "hireDate": "21221112",
  "ptoHireDate": null,
  "resignDate": "99981231",
  "resignReason": null,
  "tnaStatus": "NORMAL",
  "badgeCode": "2414",
  "payrollCode": "3231",
  "payrollOrgCode": "MIAS",
  "hourlybaseYn": "Y",
  "photo": "Photo Data",
  "photoThumbnail": null,
  "title": "SOFTWARE DEVELOPER",
  "businessTitle": "",
  "other": null,
  "qbKey": "2232232323-11111111111",
  "qbSendDate": "2022-11-25T09:55:36.273",
  "createdDate": "2022-11-25T09:48:18",
  "createdUser": "JAMESLEE",
  "modifiedDate": "2022-11-25T09:51:26.18",
  "modifiedUser": "JAMESLEE"
}

```
### Read Detailed employee info by `emplCode` request

```js
GET /EmployeeInfoRequest/GetDetailEmployeeInfo/{emplCode}
```

Endpoint to retrieve simple employee information based on their employee code.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**
```js
{
  "emplCode": "100834",
  "orgCode": "MIAS",
  "status": 1,
  "activeYn": "Y",
  "gender": "M",
  "birthDate": "19001222",
  "degree": "",
  "marriedYn": "",
  "street": "2134 NOLLA AVE.",
  "city": "VOLA",
  "state": "CA",
  "zip": "90000",
  "country": "US",
  "street2": "",
  "city2": "",
  "state2": "CA",
  "zip2": "",
  "country2": "US",
  "tel": "",
  "cell": "(456)221-2314",
  "residentStatus": "A",
  "alienNo": "",
  "i9Date": "19000101",
  "ssn": "",
  "w4Status": "S",
  "exemptions": 0,
  "memo": "",
  "contact1Name": "",
  "contact1Relationship": "",
  "contact1Addr1": "",
  "contact1Addr2": "",
  "contact1Tel": "",
  "contact1Cell": "",
  "contact2Name": "MINSOO HAN",
  "contact2Relationship": "R05",
  "contact2Addr1": "",
  "contact2Addr2": "",
  "contact2Tel": "",
  "contact2Cell": "(256)332-3123",
  "other": null,
  "createdDate": "2022-11-25T09:48:18.107",
  "createdUser": "JASONLEE",
  "modifiedDate": "2022-11-25T09:51:26.21",
  "modifiedUser": "JASONLEE"
}
```

### Read transfer history by `emplCode` request

```js
GET /EmployeeInfoRequest/GetEmployeeTransferHistory/{emplCode}
```

Endpoint to retrieve the transfer history of an employee based on their employee code.

**Parameters:**

```json
  {
    "emplCode" : "string"
  }
```

**Sample Response:**

```json
  {
    "seq": 1,
    "date": "01/04/2012",
    "hist_Type": "DEPT",
    "hist_Type_Desc": "Department Transfer",
    "old_Desc": "PP - Aero  [ Div : MP00 ]",
    "new_Desc": "Aeropostale  [ Div : MP00 ]",
    "remark": ""
  }
```

### Read awards & disciplinary actions by `emplCode` request

```js
GET /EmployeeInfoRequest/GetEmployeeAwardDiscHistory/{emplCode}
```

Endpoint to retrieve awards and disciplinary actions of an employee based on their employee code.

**Parameters:**

```json
  {
    "emplCode" : "string"
  }
```
**Sample Response:**

```json
{
    "seq": 4,
    "date": "07/01/2010",
    "rp_Type": "RP01",
    "rp_Type_Desc": "Award",
    "rp_Title": "HR OUTSTANDING ACHIEVEMENT & CONTRIBUTION",
    "remark": ""
  }
```

### Read full employee list request

```js
GET /EmployeeInfoRequest/GetAllEmployeeInfo
```

Endpoint to retrieve a list of employees.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "emplCode": "100834",
  "orgCode": "MIAS",
  "emplType": "E",
  "status": 1,
  "activeYn": "Y",
  "firstName": "MINSOO",
  "middleName": "",
  "lastName": "HAN",
  "nickName": "CHRIS",
  "divCode": "COO",
  "deptCode": "COO_20",
  "upperEmplCode": "100048",
  "comTel": "(112)112-1234",
  "comTelExt": "112",
  "comFax": "(452)232-1235",
  "comEmail": "bk.h@miasfashion.com",
  "position": "G6",
  "positionYrs": "1",
  "buildingLoc": "",
  "hireDate": "21221112",
  "ptoHireDate": null,
  "resignDate": "99981231",
  "resignReason": null,
  "tnaStatus": "NORMAL",
  "badgeCode": "2414",
  "payrollCode": "3231",
  "payrollOrgCode": "MIAS",
  "hourlybaseYn": "Y",
  "photo": "Photo Data",
  "photoThumbnail": null,
  "title": "SOFTWARE DEVELOPER",
  "businessTitle": "",
  "other": null,
  "qbKey": "2232232323-11111111111",
  "qbSendDate": "2022-11-25T09:55:36.273",
  "createdDate": "2022-11-25T09:48:18",
  "createdUser": "JAMESLEE",
  "modifiedDate": "2022-11-25T09:51:26.18",
  "modifiedUser": "JAMESLEE"
} .... all active employees
```

### Update password request

```js
PUT /EmployeeInfoRequest/UpdateUserPassword/{emplCode}
```

Endpoint to allow employees to change their login password.

**Parameters**
```json
  {
    "emplCode" : "string",
    "newPass": "string"
  }
```


**Sample Response:**

```json
{
  1
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

## Org Chart
**==Not implemented yet==**
### GET /org_chart/data request


## Insurance

### Get selected insurance information by `emplCode` request

```js
GET /Insurance/GetSelectedInsurance/{emplCode}
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

### Read insurance surfing data by `insuranceType`,`emplCode`, `coverageSelection` request

```js
GET /Insurance/UpdateInsuranceOption/{insuranceType}/{emplCode}/{selectedCoverage}
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

### Update insurance information for employee by `insuranceType`,`emplCode`, `coverageSelection`, `selectedSurfingId` request

```js
PUT /Insurance/UpdateInsuranceOption/{insuranceType}/{emplCode}/{selectedCoverage}/{selectedSurfingId}

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

### Get evaluation factors by `emplCode`, `year`, and `term` request

```js
GET /Evaluation/GetEvaluationFactors/{emplCode}
```
Endpoint to Get Evaluation Factors 
**Parameters:**

```json
{
  "emplCode": "string",
  "year": "string",
  "term": "string"
}
```

**Sample Response:**

```json
{
    "factor": "F003",
    "factor_desc": "Knowledge of Job",
    "line_display": "false",
    "factor_grade": "A",
    "grade_desc": "Has a great wealth of knowledge about all job facets",
    "f_checked": "true",
    "comment": "sdasldajdjsadsalkdasldksl",
    "group_desc": "MIAS / IT",
    "appraiser1": "DAVE KIM",
    "appraiser2": "JAE SONG",
    "open_yn": "Y"
  }
```

### Create Self Evaluation Record by `emplCode`,`year`,`term`,`comment`,`factor`,`grade`

```js
POST /Evaluation/CreateSelfEvaluation/{emplCode}
```
Endpoint to create self evaluation record for specific term
**Parameters**
```json
{
  "emplCode": "string",
  "year": "string",
  "term": "string",
  "comment": "string",
  "factor": "string",
  "grade": "string"  
}
```

**Sample Response:**

```json
{
  "msg": "Saved Successfully!"
}
```