function loadDataTable(dataTable) {
    $(dataTable.name).DataTable({
        processing: true,
        serverSide: true,
        filter: false,
        ajax: {
            url: dataTable.url,
            type: "POST",
            datatype: "json"
        },
        columnDefs: [{
            targets: [0],
            visible: false,
            searchable: false
        }],
        columns: dataTable.columns,
        createdRow: dataTable.createdRow
    });
}

export default loadDataTable;