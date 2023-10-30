# API Endpoints

## Contents
- [API Endpoints](#api-endpoints)
  - [Contents](#contents)
  - [Manager](#manager)
    - [Read managed employee `emplcode` list request](#read-managed-employee-emplcode-list-request)
  - [Employee Info](#employee-info)
    - [Read basic employee info by `emplcode` request](#read-basic-employee-info-by-emplcode-request)
    - [Read detailed employee info by `emplcode` request](#read-detailed-employee-info-by-emplcode-request)
    - [Read transfer history by `emplcode` request](#read-transfer-history-by-emplcode-request)
    - [Read awards \& disciplinary actions by `emplcode` request](#read-awards--disciplinary-actions-by-emplcode-request)
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

### Read vacation days by `emplCode` request

```js
GET /vacation_days/{emplCode}
```

Endpoint to retrieve vacation days for an employee based on their employee code.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "vacation_days": 20
}
```

### Read vacation schedule by `emplCode` request

```js
GET /vacation_schedule/{emplCode}
```

Endpoint to retrieve vacation schedule or history for an employee 
based on their employee code.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "vacation_schedule": [
    {
      "start_date": "2023-10-15",
      "end_date": "2023-10-20",
      "status": "Approved"
    },
    {
      "start_date": "2023-11-05",
      "end_date": "2023-11-10",
      "status": "Pending"
    }
  ]
}
```

### Create new day/time off request request

```js
POST /day_time_off/new_request
```

Endpoint to submit a new day/time off request.

**Sample Request:**

```json
{
  "emplCode": "1000123",
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

### Read day/time off request list by `emplCode`, `year` request

```js
GET /day_time_off/request_list/{emplCode}/{year}
```

Endpoint to retrieve a list of day/time off requests for a specific employee and year.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "requests": [
    {
      "start_date": "2023-10-15",
      "end_date": "2023-10-20",
      "status": "Approved"
    },
    {
      "start_date": "2023-11-05",
      "end_date": "2023-11-10",
      "status": "Pending"
    }
  ]
}
```

### Read list of day/time off approval requests for manager by  request `approver_id`

```js
GET /day_time_off/approval_list/{approver_id}
```

Endpoint to retrieve a list of day/time off approval requests for a manager.

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "approval_requests": [
    {
      "request_id": "request001",
      "employee_id": "empl002",
      "start_date": "2023-11-05",
      "end_date": "2023-11-10"
    }
  ]
}
```

### Read day/time off approval history by `emplCode` request

```js
GET /day_time_off/approval_history/{emplCode}
```

Endpoint to retrieve approval history for a specific employee (for managers).

**Sample Request:**

No request body for this endpoint.

**Sample Response:**

```json
{
  "approval_history": [
    {
      "request_id": "request001",
      "start_date": "2023-11-05",
      "end_date": "2023-11-10",
      "status": "Approved"
    },
    {
      "request_id": "request002",
      "start_date": "2023-10-15",
      "end_date": "2023-10-20",
      "status": "Denied"
    }
  ]
}
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