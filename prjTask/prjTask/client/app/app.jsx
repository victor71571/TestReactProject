var ReactDOM = require('react-dom');
var React = require('react');


var PersonGridRow = React.createClass({
        render : function(){
            return (
                <tr>
                    <td>{this.props.element.Id}</td>
                    <td>{this.props.element.Name}</td>
                    <td>{this.props.element.Gender}</td>
                    <td>{this.props.element.Age}</td>
                </tr>
            );
        }
    });
 
    var PersonGridTable = React.createClass({
        getInitialState: function(){
            return {
                elements:[]
            }
        },
        componentDidMount:function(){
           
            $.get(this.props.dataUrl, function(data){
                if(this.isMounted()){
                    this.setState({
                        elements: data
                    });
                }
            }.bind(this));
        },
        render : function(){
           var rows = [];
            this.state.elements.forEach(function(element){
                rows.push(<PersonGridRow key={element.Id} element={element}/>);
            });
           return (<table>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Gender</th>
                        <th>Age</th>
                    </tr>
                </thead>
                <tbody>
                    {rows}
                </tbody>
            </table>);
        }
    });
   ReactDOM.render(
        <PersonGridTable dataUrl="api/Person/GetAllPersons"/>,
        document.getElementById('app')
    );