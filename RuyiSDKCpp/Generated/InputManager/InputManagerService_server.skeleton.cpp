// This autogenerated skeleton file illustrates how to build a server.
// You should copy it to another filename to avoid overwriting it.

#include "InputManagerService.h"
#include <thrift/protocol/TBinaryProtocol.h>
#include <thrift/server/TSimpleServer.h>
#include <thrift/transport/TServerSocket.h>
#include <thrift/transport/TBufferTransports.h>

using namespace ::apache::thrift;
using namespace ::apache::thrift::protocol;
using namespace ::apache::thrift::transport;
using namespace ::apache::thrift::server;

using namespace  ::Ruyi::SDK::InputManager;

class InputManagerServiceHandler : virtual public InputManagerServiceIf {
 public:
  InputManagerServiceHandler() {
    // Your initialization goes here
  }

  bool SetRuyiControllerStatus(const int8_t channel, const bool enableR, const bool enableG, const bool enableB, const bool enableMotor1, const bool enableMotor2, const bool shutdown, const int8_t RValue, const int8_t GValue, const int8_t BValue, const int8_t motor1Value, const int8_t motor1Time, const int8_t motor2Value, const int8_t motor2Time) {
    // Your implementation goes here
    printf("SetRuyiControllerStatus\n");
  }

};

int main(int argc, char **argv) {
  int port = 9090;
  ::apache::thrift::stdcxx::shared_ptr<InputManagerServiceHandler> handler(new InputManagerServiceHandler());
  ::apache::thrift::stdcxx::shared_ptr<TProcessor> processor(new InputManagerServiceProcessor(handler));
  ::apache::thrift::stdcxx::shared_ptr<TServerTransport> serverTransport(new TServerSocket(port));
  ::apache::thrift::stdcxx::shared_ptr<TTransportFactory> transportFactory(new TBufferedTransportFactory());
  ::apache::thrift::stdcxx::shared_ptr<TProtocolFactory> protocolFactory(new TBinaryProtocolFactory());

  TSimpleServer server(processor, serverTransport, transportFactory, protocolFactory);
  server.serve();
  return 0;
}

