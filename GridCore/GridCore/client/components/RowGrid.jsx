var React = require('react');

class RowGrid extends React.Component{
    render (){
        return (
            <tr>
                <td>{this.props.item.id}</td>
                <td>{this.props.item.name}</td>
                <td>{this.props.item.gender}</td>
                <td>{this.props.item.age}</td>

            </tr>
        );
    }
}

module.exports=RowGrid;