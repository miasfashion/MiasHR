# API Endpoints

## Contents
- [API Endpoints](#api-endpoints)
  - [Contents](#contents)
  - [Manager](#manager)
    - [Read managed employee `empl_code` list request](#read-managed-employee-empl_code-list-request)
  - [Employee Info](#employee-info)
    - [Read employee info by `empl_code` request](#read-employee-info-by-empl_code-request)
    - [Read transfer history by `empl_code` request](#read-transfer-history-by-empl_code-request)
    - [Read awards \& disciplinary actions by `empl_code` request](#read-awards--disciplinary-actions-by-empl_code-request)
    - [Read full employee list request](#read-full-employee-list-request)
    - [Update password request](#update-password-request)
  - [Day/Time Off](#daytime-off)
    - [Read vacation days by `empl_code` request](#read-vacation-days-by-empl_code-request)
    - [Read vacation schedule by `empl_code` request](#read-vacation-schedule-by-empl_code-request)
    - [Create new day/time off request request](#create-new-daytime-off-request-request)
    - [Read day/time off request list by `empl_code`, `year` request](#read-daytime-off-request-list-by-empl_code-year-request)
    - [Read list of day/time off approval requests for manager by  request`approver_id`](#read-list-of-daytime-off-approval-requests-for-manager-by--requestapprover_id)
    - [Read day/time off approval history by `empl_code` request](#read-daytime-off-approval-history-by-empl_code-request)
  - [Time \& Attendance](#time--attendance)
    - [Read time \& attendance history by `empl_code`, `time_period` request](#read-time--attendance-history-by-empl_code-time_period-request)
  - [HR Request](#hr-request)
    - [Read list of HR requests by `empl_code`, `year` request](#read-list-of-hr-requests-by-empl_code-year-request)
    - [Create new HR meeting request request](#create-new-hr-meeting-request-request)
    - [Read list of pending HR meeting requests for manager by  request`approver_id`](#read-list-of-pending-hr-meeting-requests-for-manager-by--requestapprover_id)
    - [Read HR meeting history by `empl_code`, `year` request](#read-hr-meeting-history-by-empl_code-year-request)
  - [Org Chart](#org-chart)
    - [GET /org\_chart/data request](#get-org_chartdata-request)
  - [Insurance](#insurance)
    - [Read selected insurance information by `empl_code` request](#read-selected-insurance-information-by-empl_code-request)
    - [Read insurance surfing data by `empl_code`, `coverage_selection` request](#read-insurance-surfing-data-by-empl_code-coverage_selection-request)
  - [Evaluation](#evaluation)
    - [Create new self evaluation request](#create-new-self-evaluation-request)

## Manager

### Read managed employee `empl_code` list request

```js
GET /manager/empl_code_list/{approver_id}
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

### Read employee info by `empl_code` request

```js
GET /employee_info/info/{empl_code}
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

### Read transfer history by `empl_code` request

```js
GET /employee_info/transfer_history/{empl_code}
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

### Read awards & disciplinary actions by `empl_code` request

```js
GET /award_disciplinary_action/{empl_code}
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

### Read vacation days by `empl_code` request

```js
GET /vacation_days/{empl_code}
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

### Read vacation schedule by `empl_code` request

```js
GET /vacation_schedule/{empl_code}
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

### Read day/time off request list by `empl_code`, `year` request

```js
GET /day_time_off/request_list/{empl_code}/{year}
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

### Read list of day/time off approval requests for manager by  request`approver_id`

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

### Read day/time off approval history by `empl_code` request

```js
GET /day_time_off/approval_history/{empl_code}
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

### Read time & attendance history by `empl_code`, `time_period` request

```js
GET /time_attendance/history/{empl_code}/{time_period}
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

### Read list of HR requests by `empl_code`, `year` request

```js
GET /hr_request/meeting_list/{empl_code}/{year}
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


### Read HR meeting history by `empl_code`, `year` request

```js
GET /hr_request/meeting_history/{empl_code}/{year}
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

### Read selected insurance information by `empl_code` request

```js
GET /insurance/current_selection/{empl_code}
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

### Read insurance surfing data by `empl_code`, `coverage_selection` request

```js
GET /insurance_surfing/{empl_code}{coverage_selection}
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