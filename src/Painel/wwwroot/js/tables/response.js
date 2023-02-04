
import loadDataTable from '../shared/dataTable.js';
import buttons from '../shared/buttons.js';
import commonColumns from '../shared/commonColumns.js';

let dataTable = {
    name: "#response-datatable",
    url: "/api/response/get-all",
    columns: [
        ...commonColumns,
        { "data": "finishTime", "name": "Finish Time", "autoWidth": true, "orderable": false, },
        { "data": "responseStatus", "name": "Response Status", "autoWidth": true, "orderable": false, },
        buttons.responseBody,
        buttons.headers,
        buttons.request,
        buttons.log,
        buttons.exception
    ]
}

$(document).ready(loadDataTable(dataTable));