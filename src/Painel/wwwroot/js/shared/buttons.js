function GetButton(dataButton, title, classApply){
    return {
        "data": dataButton,
        "orderable": false,
        "render": function(data) { 
            return `<a title="${title}" class="${dataButton}-button btn ${classApply} btn-sm">${title}</a>`;
        }
    }
}

const buttons = {
    request: GetButton('request', 'Request', 'btn-primary'),
    response: GetButton('response', 'Response', 'btn-success'),
    log: GetButton('log', 'Log', 'btn-info'),
    exception: GetButton('exception', 'Exception', 'btn-warning'),    
    headers: GetButton('headers', 'Headers', 'btn-light'),
    requestBody: GetButton('requestBody', 'Request Body', 'btn-light'),
    queryString: GetButton('queryString', 'Query String', 'btn-light'),
    responseBody: GetButton('responseBody', 'Response Body', 'btn-light'),
    stackTrace: GetButton('stackTrace', 'Stack Trace', 'btn-light'),
};

export default buttons;