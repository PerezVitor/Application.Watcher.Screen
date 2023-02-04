
import loadDataTable from '../shared/dataTable.js';
import buttons from '../shared/buttons.js';
import commonColumns from '../shared/commonColumns.js';

const dataTable = {
    name: "#exception-datatable",
    url: "/api/exception/get-all",
    columns: [
        ...commonColumns,
        { "data": "ocurredAt", "name": "Ocurred At", "autoWidth": true, "orderable": false, },
        { "data": "message", "name": "message", "autoWidth": true, "orderable": false, },
        { "data": "typeOf", "name": "Type Of", "autoWidth": true, "orderable": false, },
        { "data": "source", "name": "Source", "autoWidth": true, "orderable": false, },
        { "data": "path", "name": "Path", "autoWidth": true, "orderable": false, },
        { "data": "method", "name": "Method", "autoWidth": true, "orderable": false, },
        buttons.queryString,
        buttons.requestBody,
        buttons.stackTrace,
        buttons.request,
        buttons.response,
        buttons.log
    ],
    createdRow: function(row, data) {
        $('.request-button', row).click(function () {
            $('#exeception-modal-query-string').modal();
        });

        $('.response-button', row).click(function () {
            alert('ALOU!')
        });

        $('.log-button', row).click(function () {
            alert('ALOU!')
        });

        $('.queryString-button', row).click(function () {
            alert('ALOU!')
        });

        $('.stackTrace-button', row).click(function () {
            alert('ALOU!')
        });

        $('.requestBody-button', row).click(function () {
            alert('ALOU!')
        });
    }
};

$(document).ready(loadDataTable(dataTable));