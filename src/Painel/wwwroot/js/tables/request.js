
import loadDataTable from '../shared/dataTable.js';
import buttons from '../shared/buttons.js';
import commonColumns from '../shared/commonColumns.js';

let dataTable = {
    name: "#request-datatable",
    url: "/api/request/get-all",
    columns: [
        ...commonColumns,
        { "data": "startTime", "name": "Start Time", "autoWidth": true, "orderable": false, },
        { "data": "path", "name": "Path", "autoWidth": true, "orderable": false, },
        { "data": "method", "name": "Method", "autoWidth": true, "orderable": false, },
        { "data": "host", "name": "Host", "autoWidth": true, "orderable": false, },
        { "data": "ipAddress", "name": "Ip Address", "autoWidth": true, "orderable": false, },
        buttons.headers,
        buttons.requestBody,
        buttons.queryString,
        buttons.response,
        buttons.log,
        buttons.exception
    ]
}

$(document).ready(loadDataTable(dataTable));