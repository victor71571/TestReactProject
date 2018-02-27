var React = require('react');
var RowGrid = require('./RowGrid.jsx')

class TableGrid extends React.Component{
    constructor(props){
        super(props);
        this.state={
            items:[]
            
        }
    }
    
    componentDidMount(){
        fetch("http://localhost:1761/api/home/getallpets")
        .then(response=>response.json())
        .then(data=>this.setState({items:data}))
    }
    
    
    render(){
        this.newFunction();
        var rows=[];
        this.state.items.forEach(function(item){
            rows.push(<RowGrid key={item.id}  item={item}/>);
        });
        
        return (
            <table className="table table-bordered table-responsive">
                <thead>
                    <tr>
                    <td>Id</td>
                    <td>Name</td>
                    <td>Gender</td>
                    <td>Age</td>
                    </tr>
                  </thead> 
                  <tbody>    
                    {rows}
                </tbody>
                </table>
           

        );
    }

    newFunction() {
        const { items } = this.state;
    }
};

module.exports=TableGrid;