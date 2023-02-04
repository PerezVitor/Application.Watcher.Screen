
import loadDataTable from '../shared/dataTable.js';
import buttons from '../shared/buttons.js';
import commonColumns from '../shared/commonColumns.js';

let dataTable = {
    name: "#log-datatable",
    url: "/api/log/get-all",
    columns: [
        ...commonColumns,
        { "data": "timestamp", "name": "Timestamp", "autoWidth": true, "orderable": false, },
        { "data": "logLevel", "name": "Log Level", "autoWidth": true, "orderable": false, },
        { "data": "message", "name": "Message", "autoWidth": true, "orderable": false, },
        { "data": "callingFrom", "name": "Calling From", "autoWidth": true, "orderable": false, },
        { "data": "callingMethod", "name": "Calling Method", "autoWidth": true, "orderable": false, },
        { "data": "lineNumber", "name": "Line Number", "autoWidth": true, "orderable": false, },
        buttons.request,
        buttons.response,
        buttons.exception
    ]
}

$(document).ready(loadDataTable(dataTable));