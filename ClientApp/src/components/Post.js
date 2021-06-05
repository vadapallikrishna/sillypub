import React, { Component } from 'react';
import { Row, Col,Card, CardImg, CardTitle, CardText, CardBody, CardSubtitle, Button} from 'reactstrap';
export class Post extends Component {
    render() {
        return <div className="row">
            <Card>
            <Row>
            <Col>
            <CardImg width="150" height="150" src="https://reactnativecode.com/wp-content/uploads/2018/02/Default_Image_Thumbnail.png"/>
            </Col>
            <CardBody>
          <CardTitle tag="h5">Review title</CardTitle>
          <CardSubtitle tag="h6" className="mb-2 text-muted">Time ago by author</CardSubtitle>
          <CardText>This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</CardText>
          <Button>Share</Button>
            </CardBody>
            </Row>
            </Card>
        </div>
    }
}